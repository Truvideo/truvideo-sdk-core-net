using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Service.Connectivity {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.service.connectivity']/interface[@name='ConnectivityService']"
	[Register ("truvideo/sdk/common/service/connectivity/ConnectivityService", "", "Truvideo.Sdk.Common.Service.Connectivity.IConnectivityServiceInvoker")]
	public partial interface IConnectivityService : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.connectivity']/interface[@name='ConnectivityService']/method[@name='isOnline' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super java.lang.Boolean&gt;']]"
		[Register ("isOnline", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetIsOnline_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Connectivity.IConnectivityServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? IsOnline (global::Kotlin.Coroutines.IContinuation p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.connectivity']/interface[@name='ConnectivityService']/method[@name='validateConnectivity' and count(parameter)=1 and parameter[1][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("validateConnectivity", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetValidateConnectivity_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Connectivity.IConnectivityServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? ValidateConnectivity (global::Kotlin.Coroutines.IContinuation p0);

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/service/connectivity/ConnectivityService", DoNotGenerateAcw=true)]
	internal partial class IConnectivityServiceInvoker : global::Java.Lang.Object, IConnectivityService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/connectivity/ConnectivityService", typeof (IConnectivityServiceInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IConnectivityService? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConnectivityService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.service.connectivity.ConnectivityService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConnectivityServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_isOnline_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetIsOnline_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_isOnline_Lkotlin_coroutines_Continuation_ == null)
				cb_isOnline_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_IsOnline_Lkotlin_coroutines_Continuation_));
			return cb_isOnline_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_IsOnline_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Connectivity.IConnectivityService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IsOnline (p0!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isOnline_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? IsOnline (global::Kotlin.Coroutines.IContinuation p0)
		{
			if (id_isOnline_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_isOnline_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "isOnline", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isOnline_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_validateConnectivity_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetValidateConnectivity_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_validateConnectivity_Lkotlin_coroutines_Continuation_ == null)
				cb_validateConnectivity_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_ValidateConnectivity_Lkotlin_coroutines_Continuation_));
			return cb_validateConnectivity_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_ValidateConnectivity_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Connectivity.IConnectivityService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ValidateConnectivity (p0!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_validateConnectivity_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? ValidateConnectivity (global::Kotlin.Coroutines.IContinuation p0)
		{
			if (id_validateConnectivity_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_validateConnectivity_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "validateConnectivity", "(Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_validateConnectivity_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
