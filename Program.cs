﻿using System;
using System.Collections.Generic;
using Autodesk.Fbx;
using SoulsFormats;
using System.Linq;
namespace Ds3FbxSharp
{
    class Program
    {
        enum ModelDataType
        {
            Flver,
            Hkx,
            Unk,
        }

        private static ModelDataType GetModelDataType(byte[] fileContents)
        {
            if (FLVER2.Is(fileContents))
            {
                return ModelDataType.Flver;
            }

            if (HKX.Is(fileContents))
            {
                return ModelDataType.Hkx;
            }

            return ModelDataType.Unk;
        }

        static void PrintFbxNode(FbxNode node, string prefix = "")
        {
            Console.WriteLine(prefix + node.GetName());

            for (int childIndex = 0; childIndex < node.GetChildCount(); ++childIndex)
            {
                PrintFbxNode(node.GetChild(childIndex), prefix + "--");
            }
        }

        static IEnumerable<T> GetHkxObjects<T>(IEnumerable<HKX> hkxs) where T: HKX.HKXObject
        {
            return hkxs.SelectMany(hkx => hkx.DataSection.Objects).Where(hkxObject => hkxObject is T).Select(hkxObject => (T)hkxObject);
        }

        static void Main(string[] args)
        {
            //var reader = new SoulsFormats.BXF4Reader(@"G:\SteamLibrary\steamapps\common\DARK SOULS III\Game\Data1.bhd", @"G:\SteamLibrary\steamapps\common\DARK SOULS III\Game\Data1.bdt");
            //FLVER2 flver = reader.Files.Where(file => file.Name.Contains("1300"))
            //    .Select(file => reader.ReadFile(file))
            //    .Select(fileContents => new BND4Reader(fileContents))
            //    .SelectMany(bndReader => bndReader.Files.Select(file => bndReader.ReadFile(file)))
            //    .Where(fileContents => FLVER2.Is(fileContents))
            //    .Select(fileContents => FLVER2.Read(fileContents))
            //    .First();

            /*FLVER2 flver =*/

            string charToLookFor = "1300";

            if (args.Length > 0)
            {
                charToLookFor = args[0];
            }

            var fileLookup = System.IO.Directory.GetFiles(@"G:\SteamLibrary\steamapps\common\DARK SOULS III\Game\chr\", string.Format(System.Globalization.CultureInfo.InvariantCulture, "*{0}*bnd.dcx", charToLookFor))
                .Concat(System.IO.Directory.GetFiles(@"G:\SteamLibrary\steamapps\common\DARK SOULS III\Game\parts\", "bd_m_*bnd.dcx"))
                .Select(path => new BND4Reader(path))
                .SelectMany(bndReader => bndReader.Files.Where(file=>{
                    if (file.Name.EndsWith("hkx"))
                    {
                        bool isAnimHkx = file.Name.Substring(file.Name.LastIndexOf("\\") + 1).StartsWith("a20");

                        return isAnimHkx;
                    }
                    return true;
                }).Select(file => bndReader.ReadFile(file)))
                //.GroupBy(fileContents=>GetModelDataType(fileContents))
                //.ToDictionary()
                .ToLookup(GetModelDataType)
                //.Where(fileContents => FLVER2.Is(fileContents))
                //.Select(fileContents => FLVER2.Read(fileContents))
                //.First()
                ;

            FLVER2 flver = fileLookup[ModelDataType.Flver].Select(FLVER2.Read).Where(flver=>flver.Meshes.Count > 0).ElementAt(1);
            var hkxs = fileLookup[ModelDataType.Hkx].Select(HKX.Read);
            var skeletons = GetHkxObjects<HKX.HKASkeleton>(hkxs);

            HKX.HKASkeleton hkaSkeleton = skeletons.FirstOrDefault();


            HKX.HKAAnimationBinding binding = GetHkxObjects<HKX.HKAAnimationBinding>(hkxs).First();

            FbxManager m = FbxManager.Create();

            FbxScene scene = FbxScene.Create(m, "BlackKnight");



            FbxNode sceneRoot = scene.GetRootNode();

            var meshes = flver?.Meshes.Select(mesh => new MeshExportData() { mesh = mesh, meshRoot = flver.Bones[mesh.DefaultBoneIndex] })
                .Select(meshExportData => new MeshExporter(scene, meshExportData))
                .Select(exporter => exporter.Fbx.CreateExportData(exporter.Souls))
                .ToList();

            if (meshes != null)
            {
                foreach (var exportedMesh in meshes)
                {
                    sceneRoot.AddChild(exportedMesh.FbxNode);
                }
            }

            List<DsBone> bones = SkeletonFixup.FixupDsBones(flver, hkaSkeleton).ToList();

            DsSkeleton skeleton = new SkeletonExporter(scene, flver, bones).ParseSkeleton();

            if (meshes != null)
            {
                foreach (var meshData in meshes)
                {
                    FbxSkin generatedSkin = new SkinExporter(meshData.FbxData, new SkinExportData(meshData.SoulsData, skeleton, flver)).Fbx;
                    meshData.FbxData.AddDeformer(generatedSkin);
                };
            }

            {
                FbxPose pose = FbxPose.Create(scene, "Pose");

                pose.SetIsBindPose(true);

                foreach (var skeletonBone in skeleton.boneDatas)
                {
                    var boneTransform = skeletonBone.exportData.FbxNode.EvaluateGlobalTransform();
                    pose.Add(skeletonBone.exportData.FbxNode, new FbxMatrix(boneTransform));
                }

                scene.AddPose(pose);
            }

            Func<HKX.HKASplineCompressedAnimation, int, bool> b = ((animation, animIndex) =>
            {
                DSAnimStudio.NewHavokAnimation_SplineCompressedData anim = new DSAnimStudio.NewHavokAnimation_SplineCompressedData(animation, hkaSkeleton, binding);

                var animExporter = new AnimationExporter(scene, new AnimationExportData() { dsAnimation = anim, hkaAnimationBinding = binding, skeleton = skeleton, name = animIndex.ToString() });

                var dummy = animExporter.Fbx;

                return dummy == null;

            });

            var animations11 = GetHkxObjects<HKX.HKASplineCompressedAnimation>(hkxs).Take(5).ToList();

            int maxAnimCount = 100;

            for (int i = 0; i< animations11.Count && i < maxAnimCount; ++i)
            {
                b(animations11[i], i);
            }

            PrintFbxNode(sceneRoot);

            using (FbxExporter ex = FbxExporter.Create(m, "Exporter"))
            {
                ex.Initialize(charToLookFor + "_out.fbx");

                Console.WriteLine(ex.Export(scene));
            }

            m.Destroy();

            Console.WriteLine("All done");
        }
    }
}
