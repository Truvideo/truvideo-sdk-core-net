using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Domain.Usecases {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.domain.usecases']/interface[@name='RegisterDeviceUseCase']"
	[Register ("truvideo/sdk/common/domain/usecases/RegisterDeviceUseCase", "", "Truvideo.Sdk.Common.Domain.Usecases.IRegisterDeviceUseCaseInvoker")]
	public partial interface IRegisterDeviceUseCase : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.domain.usecases']/interface[@name='RegisterDeviceUseCase']/method[@name='invoke' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.Long'] and parameter[7][@type='java.lang.Long'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='kotlin.coroutines.Continuation&lt;? super truvideo.sdk.common.model.TruvideoSdkAuthentication&gt;']]"
		[Register ("invoke", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetInvoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Domain.Usecases.IRegisterDeviceUseCaseInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Invoke (string baseUrl, string apiKey, string payload, string signature, string? deviceID, global::Java.Lang.Long? p5, global::Java.Lang.Long? p6, string externalId, global::Kotlin.Coroutines.IContinuation p8);

		// Metadata.xml XPath class reference: path="/api/package[@name='truvideo.sdk.common.domain.usecases']/class[@name='RegisterDeviceUseCase.DefaultImpls']"
		[global::Android.Runtime.Register ("truvideo/sdk/common/domain/usecases/RegisterDeviceUseCase$DefaultImpls", DoNotGenerateAcw=true)]
		public sealed partial class DefaultImpls : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/domain/usecases/RegisterDeviceUseCase$DefaultImpls", typeof (DefaultImpls));

			internal static IntPtr class_ref {
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
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			internal DefaultImpls (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

		}

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/domain/usecases/RegisterDeviceUseCase", DoNotGenerateAcw=true)]
	internal partial class IRegisterDeviceUseCaseInvoker : global::Java.Lang.Object, IRegisterDeviceUseCase {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/domain/usecases/RegisterDeviceUseCase", typeof (IRegisterDeviceUseCaseInvoker));

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

		public static IRegisterDeviceUseCase? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IRegisterDeviceUseCase> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.domain.usecases.RegisterDeviceUseCase'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IRegisterDeviceUseCaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetInvoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLLLL_L (n_Invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_));
			return cb_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseUrl, IntPtr native_apiKey, IntPtr native_payload, IntPtr native_signature, IntPtr native_deviceID, IntPtr native_p5, IntPtr native_p6, IntPtr native_externalId, IntPtr native_p8)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Domain.Usecases.IRegisterDeviceUseCase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var baseUrl = JNIEnv.GetString (native_baseUrl, JniHandleOwnership.DoNotTransfer);
			var apiKey = JNIEnv.GetString (native_apiKey, JniHandleOwnership.DoNotTransfer);
			var payload = JNIEnv.GetString (native_payload, JniHandleOwnership.DoNotTransfer);
			var signature = JNIEnv.GetString (native_signature, JniHandleOwnership.DoNotTransfer);
			var deviceID = JNIEnv.GetString (native_deviceID, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p5, JniHandleOwnership.DoNotTransfer);
			var p6 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p6, JniHandleOwnership.DoNotTransfer);
			var externalId = JNIEnv.GetString (native_externalId, JniHandleOwnership.DoNotTransfer);
			var p8 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p8, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Invoke (baseUrl!, apiKey!, payload!, signature!, deviceID, p5, p6, externalId!, p8!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Invoke (string baseUrl, string apiKey, string payload, string signature, string? deviceID, global::Java.Lang.Long? p5, global::Java.Lang.Long? p6, string externalId, global::Kotlin.Coroutines.IContinuation p8)
		{
			if (id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "invoke", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_baseUrl = JNIEnv.NewString ((string?)baseUrl);
			IntPtr native_apiKey = JNIEnv.NewString ((string?)apiKey);
			IntPtr native_payload = JNIEnv.NewString ((string?)payload);
			IntPtr native_signature = JNIEnv.NewString ((string?)signature);
			IntPtr native_deviceID = JNIEnv.NewString ((string?)deviceID);
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			JValue* __args = stackalloc JValue [9];
			__args [0] = new JValue (native_baseUrl);
			__args [1] = new JValue (native_apiKey);
			__args [2] = new JValue (native_payload);
			__args [3] = new JValue (native_signature);
			__args [4] = new JValue (native_deviceID);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			__args [6] = new JValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
			__args [7] = new JValue (native_externalId);
			__args [8] = new JValue ((p8 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p8).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_invoke_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_baseUrl);
			JNIEnv.DeleteLocalRef (native_apiKey);
			JNIEnv.DeleteLocalRef (native_payload);
			JNIEnv.DeleteLocalRef (native_signature);
			JNIEnv.DeleteLocalRef (native_deviceID);
			JNIEnv.DeleteLocalRef (native_externalId);
			return __ret;
		}

	}
}
