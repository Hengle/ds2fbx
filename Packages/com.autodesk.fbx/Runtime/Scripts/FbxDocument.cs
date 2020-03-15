//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.1
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Autodesk.Fbx {

public class FbxDocument : FbxCollection {
  internal FbxDocument(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxDocument Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxDocument_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocument(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxDocument Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxDocument_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocument(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDocumentInfo GetDocumentInfo() {
    global::System.IntPtr cPtr = NativeMethods.FbxDocument_GetDocumentInfo(swigCPtr);
    FbxDocumentInfo ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxDocumentInfo(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetDocumentInfo(FbxDocumentInfo pSceneInfo) {
    NativeMethods.FbxDocument_SetDocumentInfo(swigCPtr, FbxDocumentInfo.getCPtr(pSceneInfo));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxDocument other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxDocument;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxDocument).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxDocument a, FbxDocument b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxDocument a, FbxDocument b) {
    return !(a == b);
  }

}

}
