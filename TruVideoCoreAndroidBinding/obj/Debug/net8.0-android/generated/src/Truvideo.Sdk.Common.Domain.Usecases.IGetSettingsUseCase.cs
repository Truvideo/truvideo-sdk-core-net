using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Domain.Usecases {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.domain.usecases']/interface[@name='GetSettingsUseCase']"
	[Register ("truvideo/sdk/common/domain/usecases/GetSettingsUseCase", "", "Truvideo.Sdk.Common.Domain.Usecases.IGetSettingsUseCaseInvoker")]
	public partial interface IGetSettingsUseCase : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.domain.usecases']/interface[@name='GetSettingsUseCase']/method[@name='invoke' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super truvideo.sdk.common.model.TruvideoSdkSettings&gt;']]"
		[Register ("invoke", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Domain.Usecases.IGetSettingsUseCaseInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Invoke (string baseUrl, string deviceID, string accessToken, global::Kotlin.Coroutines.IContinuation p3);

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/domain/usecases/GetSettingsUseCase", DoNotGenerateAcw=true)]
	internal partial class IGetSettingsUseCaseInvoker : global::Java.Lang.Object, IGetSettingsUseCase {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/domain/usecases/GetSettingsUseCase", typeof (IGetSettingsUseCaseInvoker));

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

		public static IGetSettingsUseCase? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IGetSettingsUseCase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.domain.usecases.GetSettingsUseCase'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IGetSettingsUseCaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_L (n_Invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_));
			return cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseUrl, IntPtr native_deviceID, IntPtr native_accessToken, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Domain.Usecases.IGetSettingsUseCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var baseUrl = JNIEnv.GetString (native_baseUrl, JniHandleOwnership.DoNotTransfer);
			var deviceID = JNIEnv.GetString (native_deviceID, JniHandleOwnership.DoNotTransfer);
			var accessToken = JNIEnv.GetString (native_accessToken, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (baseUrl!, deviceID!, accessToken!, p3!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Invoke (string baseUrl, string deviceID, string accessToken, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_baseUrl = JNIEnv.NewString ((string?)baseUrl);
			IntPtr native_deviceID = JNIEnv.NewString ((string?)deviceID);
			IntPtr native_accessToken = JNIEnv.NewString ((string?)accessToken);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_baseUrl);
			__args [1] = new JValue (native_deviceID);
			__args [2] = new JValue (native_accessToken);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_baseUrl);
			JNIEnv.DeleteLocalRef (native_deviceID);
			JNIEnv.DeleteLocalRef (native_accessToken);
			return __ret;
		}

	}
}
