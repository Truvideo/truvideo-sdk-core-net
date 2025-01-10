using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Truvideo.Sdk.Core.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdkCallback']"
	[Register ("com/truvideo/sdk/core/interfaces/TruvideoSdkCallback", "", "Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallbackInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface ITruvideoSdkCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdkCallback']/method[@name='onComplete' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("onComplete", "(Ljava/lang/Object;)V", "GetOnComplete_Ljava_lang_Object_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallbackInvoker, TruVideoCoreAndroidBinding")]
		void OnComplete (global::Java.Lang.Object? result);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdkCallback']/method[@name='onError' and count(parameter)=1 and parameter[1][@type='truvideo.sdk.common.exceptions.TruvideoSdkException']]"
		[Register ("onError", "(Ltruvideo/sdk/common/exceptions/TruvideoSdkException;)V", "GetOnError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallbackInvoker, TruVideoCoreAndroidBinding")]
		void OnError (global::Truvideo.Sdk.Common.Exceptions.TruvideoSdkException exception);

	}

	[global::Android.Runtime.Register ("com/truvideo/sdk/core/interfaces/TruvideoSdkCallback", DoNotGenerateAcw=true)]
	internal partial class ITruvideoSdkCallbackInvoker : global::Java.Lang.Object, ITruvideoSdkCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/truvideo/sdk/core/interfaces/TruvideoSdkCallback", typeof (ITruvideoSdkCallbackInvoker));

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

		public static ITruvideoSdkCallback? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITruvideoSdkCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.truvideo.sdk.core.interfaces.TruvideoSdkCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITruvideoSdkCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onComplete_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOnComplete_Ljava_lang_Object_Handler ()
		{
			if (cb_onComplete_Ljava_lang_Object_ == null)
				cb_onComplete_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnComplete_Ljava_lang_Object_));
			return cb_onComplete_Ljava_lang_Object_;
		}

		static void n_OnComplete_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_result)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_result, JniHandleOwnership.DoNotTransfer);
			__this.OnComplete (result);
		}
#pragma warning restore 0169

		IntPtr id_onComplete_Ljava_lang_Object_;
		public unsafe void OnComplete (global::Java.Lang.Object? result)
		{
			if (id_onComplete_Ljava_lang_Object_ == IntPtr.Zero)
				id_onComplete_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "onComplete", "(Ljava/lang/Object;)V");
			IntPtr native_result = JNIEnv.ToLocalJniHandle (result);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_result);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onComplete_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_result);
		}

		static Delegate? cb_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_;
#pragma warning disable 0169
		static Delegate GetOnError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_Handler ()
		{
			if (cb_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_ == null)
				cb_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_OnError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_));
			return cb_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_;
		}

		static void n_OnError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var exception = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Exceptions.TruvideoSdkException> (native_exception, JniHandleOwnership.DoNotTransfer);
			__this.OnError (exception!);
		}
#pragma warning restore 0169

		IntPtr id_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_;
		public unsafe void OnError (global::Truvideo.Sdk.Common.Exceptions.TruvideoSdkException exception)
		{
			if (id_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_ == IntPtr.Zero)
				id_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_ = JNIEnv.GetMethodID (class_ref, "onError", "(Ltruvideo/sdk/common/exceptions/TruvideoSdkException;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((exception == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) exception).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onError_Ltruvideo_sdk_common_exceptions_TruvideoSdkException_, __args);
		}

	}
}
