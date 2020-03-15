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

public class FbxConstraintParent : FbxConstraint {
  internal FbxConstraintParent(global::System.IntPtr cPtr, bool ignored) : base(cPtr, ignored) { }

  // override void Dispose() {base.Dispose();}

  public new static FbxConstraintParent Create(FbxManager pManager, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxConstraintParent_Create__SWIG_0(FbxManager.getCPtr(pManager), pName);
    FbxConstraintParent ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintParent(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static FbxConstraintParent Create(FbxObject pContainer, string pName) {
    global::System.IntPtr cPtr = NativeMethods.FbxConstraintParent_Create__SWIG_1(FbxObject.getCPtr(pContainer), pName);
    FbxConstraintParent ret = (cPtr == global::System.IntPtr.Zero) ? null : new FbxConstraintParent(cPtr, false);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxPropertyBool AffectTranslationX {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectTranslationX_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectTranslationY {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectTranslationY_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectTranslationZ {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectTranslationZ_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectRotationX {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectRotationX_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectRotationY {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectRotationY_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectRotationZ {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectRotationZ_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectScalingX {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectScalingX_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectScalingY {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectScalingY_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public FbxPropertyBool AffectScalingZ {
    get {
      FbxPropertyBool ret = new FbxPropertyBool(NativeMethods.FbxConstraintParent_AffectScalingZ_get(swigCPtr), false);
      if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void SetTranslationOffset(FbxObject pObject, FbxVector4 pTranslation) {
    NativeMethods.FbxConstraintParent_SetTranslationOffset(swigCPtr, FbxObject.getCPtr(pObject), pTranslation);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetTranslationOffset(FbxObject pObject) {
    var ret = NativeMethods.FbxConstraintParent_GetTranslationOffset(swigCPtr, FbxObject.getCPtr(pObject));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void SetRotationOffset(FbxObject pObject, FbxVector4 pRotation) {
    NativeMethods.FbxConstraintParent_SetRotationOffset(swigCPtr, FbxObject.getCPtr(pObject), pRotation);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public FbxVector4 GetRotationOffset(FbxObject pObject) {
    var ret = NativeMethods.FbxConstraintParent_GetRotationOffset(swigCPtr, FbxObject.getCPtr(pObject));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void AddConstraintSource(FbxObject pObject, double pWeight) {
    NativeMethods.FbxConstraintParent_AddConstraintSource__SWIG_0(swigCPtr, FbxObject.getCPtr(pObject), pWeight);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void AddConstraintSource(FbxObject pObject) {
    NativeMethods.FbxConstraintParent_AddConstraintSource__SWIG_1(swigCPtr, FbxObject.getCPtr(pObject));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetConstrainedObject(FbxObject pObject) {
    NativeMethods.FbxConstraintParent_SetConstrainedObject(swigCPtr, FbxObject.getCPtr(pObject));
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public override int GetHashCode(){
      return swigCPtr.Handle.GetHashCode();
  }

  public bool Equals(FbxConstraintParent other) {
    if (object.ReferenceEquals(other, null)) { return false; }
    return this.swigCPtr.Handle.Equals (other.swigCPtr.Handle);
  }

  public override bool Equals(object obj){
    if (object.ReferenceEquals(obj, null)) { return false; }
    /* is obj a subclass of this type; if so use our Equals */
    var typed = obj as FbxConstraintParent;
    if (!object.ReferenceEquals(typed, null)) {
      return this.Equals(typed);
    }
    /* are we a subclass of the other type; if so use their Equals */
    if (typeof(FbxConstraintParent).IsSubclassOf(obj.GetType())) {
      return obj.Equals(this);
    }
    /* types are unrelated; can't be a match */
    return false;
  }

  public static bool operator == (FbxConstraintParent a, FbxConstraintParent b) {
    if (object.ReferenceEquals(a, b)) { return true; }
    if (object.ReferenceEquals(a, null) || object.ReferenceEquals(b, null)) { return false; }
    return a.Equals(b);
  }

  public static bool operator != (FbxConstraintParent a, FbxConstraintParent b) {
    return !(a == b);
  }

}

}
