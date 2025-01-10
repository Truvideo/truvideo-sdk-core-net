using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Service.Log.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.service.log.interfaces']/interface[@name='LogFileUploadHandler']"
	[Register ("truvideo/sdk/common/service/log/interfaces/LogFileUploadHandler", "", "Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandlerInvoker")]
	public partial interface ILogFileUploadHandler : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log.interfaces']/interface[@name='LogFileUploadHandler']/method[@name='upload' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='truvideo.sdk.common.model.TruvideoSdkStorageCredentials'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super java.lang.String&gt;']]"
		[Register ("upload", "(Ljava/lang/String;Ltruvideo/sdk/common/model/TruvideoSdkStorageCredentials;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetUpload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandlerInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Upload (string path, global::Truvideo.Sdk.Common.Model.TruvideoSdkStorageCredentials credentials, global::Kotlin.Coroutines.IContinuation p2);

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/service/log/interfaces/LogFileUploadHandler", DoNotGenerateAcw=true)]
	internal partial class ILogFileUploadHandlerInvoker : global::Java.Lang.Object, ILogFileUploadHandler {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/log/interfaces/LogFileUploadHandler", typeof (ILogFileUploadHandlerInvoker));

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

		public static ILogFileUploadHandler? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogFileUploadHandler> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.service.log.interfaces.LogFileUploadHandler'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogFileUploadHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetUpload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_ == null)
				cb_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_L (n_Upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_));
			return cb_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path, IntPtr native_credentials, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			var credentials = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Model.TruvideoSdkStorageCredentials> (native_credentials, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Upload (path!, credentials!, p2!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Upload (string path, global::Truvideo.Sdk.Common.Model.TruvideoSdkStorageCredentials credentials, global::Kotlin.Coroutines.IContinuation p2)
		{
			if (id_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "upload", "(Ljava/lang/String;Ltruvideo/sdk/common/model/TruvideoSdkStorageCredentials;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_path = JNIEnv.NewString ((string?)path);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_path);
			__args [1] = new JValue ((credentials == null) ? IntPtr.Zero : ((global::Java.Lang.Object) credentials).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_upload_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkStorageCredentials_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_path);
			return __ret;
		}

	}
}
