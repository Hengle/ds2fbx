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

public class FbxLimits : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxLimits(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxLimits obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxLimits() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NativeMethods.delete_FbxLimits(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public FbxLimits() : this(NativeMethods.new_FbxLimits(), true) {
  }

  public bool GetActive() {
    bool ret = NativeMethods.FbxLimits_GetActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetActive(bool pActive) {
    NativeMethods.FbxLimits_SetActive(swigCPtr, pActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public bool GetMinXActive() {
    bool ret = NativeMethods.FbxLimits_GetMinXActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetMinYActive() {
    bool ret = NativeMethods.FbxLimits_GetMinYActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetMinZActive() {
    bool ret = NativeMethods.FbxLimits_GetMinZActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDouble3 GetMin() {
    var ret = NativeMethods.FbxLimits_GetMin(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMinXActive(bool pActive) {
    NativeMethods.FbxLimits_SetMinXActive(swigCPtr, pActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMinYActive(bool pActive) {
    NativeMethods.FbxLimits_SetMinYActive(swigCPtr, pActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMinZActive(bool pActive) {
    NativeMethods.FbxLimits_SetMinZActive(swigCPtr, pActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMinActive(bool pXActive, bool pYActive, bool pZActive) {
    NativeMethods.FbxLimits_SetMinActive(swigCPtr, pXActive, pYActive, pZActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMin(FbxDouble3 pMin) {
    NativeMethods.FbxLimits_SetMin(swigCPtr, pMin);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public bool GetMaxXActive() {
    bool ret = NativeMethods.FbxLimits_GetMaxXActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetMaxYActive() {
    bool ret = NativeMethods.FbxLimits_GetMaxYActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool GetMaxZActive() {
    bool ret = NativeMethods.FbxLimits_GetMaxZActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDouble3 GetMax() {
    var ret = NativeMethods.FbxLimits_GetMax(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMaxXActive(bool pActive) {
    NativeMethods.FbxLimits_SetMaxXActive(swigCPtr, pActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMaxYActive(bool pActive) {
    NativeMethods.FbxLimits_SetMaxYActive(swigCPtr, pActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMaxZActive(bool pActive) {
    NativeMethods.FbxLimits_SetMaxZActive(swigCPtr, pActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMaxActive(bool pXActive, bool pYActive, bool pZActive) {
    NativeMethods.FbxLimits_SetMaxActive(swigCPtr, pXActive, pYActive, pZActive);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public void SetMax(FbxDouble3 pMax) {
    NativeMethods.FbxLimits_SetMax(swigCPtr, pMax);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
  }

  public bool GetAnyMinMaxActive() {
    bool ret = NativeMethods.FbxLimits_GetAnyMinMaxActive(swigCPtr);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

  public FbxDouble3 Apply(FbxDouble3 pVector) {
    var ret = NativeMethods.FbxLimits_Apply(swigCPtr, pVector);
    if (NativeMethods.SWIGPendingException.Pending) throw NativeMethods.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
