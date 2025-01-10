using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Truvideo.Sdk.Core.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']"
	[Register ("com/truvideo/sdk/core/interfaces/TruvideoSdk", "", "Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker")]
	public partial interface ITruvideoSdk : IJavaObject, IJavaPeerable {
		string ApiKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='getApiKey' and count(parameter)=0]"
			[Register ("getApiKey", "()Ljava/lang/String;", "GetGetApiKeyHandler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		string Environment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='getEnvironment' and count(parameter)=0]"
			[Register ("getEnvironment", "()Ljava/lang/String;", "GetGetEnvironmentHandler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		bool IsAuthenticationExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='isAuthenticationExpired' and count(parameter)=0]"
			[Register ("isAuthenticationExpired", "()Z", "GetIsAuthenticationExpiredHandler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='authenticate' and count(parameter)=7 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.Long'] and parameter[5][@type='java.lang.Long'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("authenticate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Authenticate (string apiKey, string payload, string signature, global::Java.Lang.Long? p3, global::Java.Lang.Long? p4, string externalId, global::Kotlin.Coroutines.IContinuation p6);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='authenticate' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='com.truvideo.sdk.core.interfaces.TruvideoSdkCallback&lt;kotlin.Unit&gt;']]"
		[Register ("authenticate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkCallback;)V", "GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		void Authenticate (string apiKey, string payload, string signature, string externalId, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='clearAuthentication' and count(parameter)=0]"
		[Register ("clearAuthentication", "()V", "GetClearAuthenticationHandler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		void ClearAuthentication ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='generatePayload' and count(parameter)=0]"
		[Register ("generatePayload", "()Ljava/lang/String;", "GetGeneratePayloadHandler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		string GeneratePayload ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='handleAuthentication' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.truvideo.sdk.core.interfaces.TruvideoSdkSignatureProvider'] and parameter[4][@type='com.truvideo.sdk.core.interfaces.TruvideoSdkCallback&lt;kotlin.Unit&gt;'] and parameter[5][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("handleAuthentication", "(Ljava/lang/String;Ljava/lang/String;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkSignatureProvider;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkCallback;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetHandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? HandleAuthentication (string apiKey, string externalId, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider signatureProvider, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback @callback, global::Kotlin.Coroutines.IContinuation p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='handleAuthentication' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.truvideo.sdk.core.interfaces.TruvideoSdkSignatureProvider'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("handleAuthentication", "(Ljava/lang/String;Ljava/lang/String;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkSignatureProvider;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetHandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? HandleAuthentication (string apiKey, string externalId, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider signatureProvider, global::Kotlin.Coroutines.IContinuation p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='initAuthentication' and count(parameter)=1 and parameter[1][@type='com.truvideo.sdk.core.interfaces.TruvideoSdkCallback&lt;kotlin.Unit&gt;']]"
		[Register ("initAuthentication", "(Lcom/truvideo/sdk/core/interfaces/TruvideoSdkCallback;)V", "GetInitAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		void InitAuthentication (global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback @callback);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdk']/method[@name='initAuthentication' and count(parameter)=3 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("initAuthentication", "(Ljava/lang/Long;Ljava/lang/Long;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetInitAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? InitAuthentication (global::Java.Lang.Long? p0, global::Java.Lang.Long? p1, global::Kotlin.Coroutines.IContinuation p2);

		// Metadata.xml XPath class reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/class[@name='TruvideoSdk.DefaultImpls']"
		[global::Android.Runtime.Register ("com/truvideo/sdk/core/interfaces/TruvideoSdk$DefaultImpls", DoNotGenerateAcw=true)]
		public sealed partial class DefaultImpls : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/truvideo/sdk/core/interfaces/TruvideoSdk$DefaultImpls", typeof (DefaultImpls));

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

	[global::Android.Runtime.Register ("com/truvideo/sdk/core/interfaces/TruvideoSdk", DoNotGenerateAcw=true)]
	internal partial class ITruvideoSdkInvoker : global::Java.Lang.Object, ITruvideoSdk {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/truvideo/sdk/core/interfaces/TruvideoSdk", typeof (ITruvideoSdkInvoker));

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

		public static ITruvideoSdk? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITruvideoSdk> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.truvideo.sdk.core.interfaces.TruvideoSdk'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITruvideoSdkInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getApiKey;
#pragma warning disable 0169
		static Delegate GetGetApiKeyHandler ()
		{
			if (cb_getApiKey == null)
				cb_getApiKey = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetApiKey));
			return cb_getApiKey;
		}

		static IntPtr n_GetApiKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ApiKey);
		}
#pragma warning restore 0169

		IntPtr id_getApiKey;
		public unsafe string ApiKey {
			get {
				if (id_getApiKey == IntPtr.Zero)
					id_getApiKey = JNIEnv.GetMethodID (class_ref, "getApiKey", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getApiKey), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getEnvironment;
#pragma warning disable 0169
		static Delegate GetGetEnvironmentHandler ()
		{
			if (cb_getEnvironment == null)
				cb_getEnvironment = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetEnvironment));
			return cb_getEnvironment;
		}

		static IntPtr n_GetEnvironment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Environment);
		}
#pragma warning restore 0169

		IntPtr id_getEnvironment;
		public unsafe string Environment {
			get {
				if (id_getEnvironment == IntPtr.Zero)
					id_getEnvironment = JNIEnv.GetMethodID (class_ref, "getEnvironment", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEnvironment), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_isAuthenticated;
#pragma warning disable 0169
		static Delegate GetIsAuthenticatedHandler ()
		{
			if (cb_isAuthenticated == null)
				cb_isAuthenticated = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsAuthenticated));
			return cb_isAuthenticated;
		}

		static bool n_IsAuthenticated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsAuthenticated;
		}
#pragma warning restore 0169

		IntPtr id_isAuthenticated;
		public unsafe bool IsAuthenticated {
			get {
				if (id_isAuthenticated == IntPtr.Zero)
					id_isAuthenticated = JNIEnv.GetMethodID (class_ref, "isAuthenticated", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthenticated);
			}
		}

		static Delegate? cb_isAuthenticationExpired;
#pragma warning disable 0169
		static Delegate GetIsAuthenticationExpiredHandler ()
		{
			if (cb_isAuthenticationExpired == null)
				cb_isAuthenticationExpired = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsAuthenticationExpired));
			return cb_isAuthenticationExpired;
		}

		static bool n_IsAuthenticationExpired (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsAuthenticationExpired;
		}
#pragma warning restore 0169

		IntPtr id_isAuthenticationExpired;
		public unsafe bool IsAuthenticationExpired {
			get {
				if (id_isAuthenticationExpired == IntPtr.Zero)
					id_isAuthenticationExpired = JNIEnv.GetMethodID (class_ref, "isAuthenticationExpired", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthenticationExpired);
			}
		}

		static Delegate? cb_getVersion;
#pragma warning disable 0169
		static Delegate GetGetVersionHandler ()
		{
			if (cb_getVersion == null)
				cb_getVersion = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetVersion));
			return cb_getVersion;
		}

		static IntPtr n_GetVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.Version);
		}
#pragma warning restore 0169

		IntPtr id_getVersion;
		public unsafe string Version {
			get {
				if (id_getVersion == IntPtr.Zero)
					id_getVersion = JNIEnv.GetMethodID (class_ref, "getVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getVersion), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLL_L (n_Authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_));
			return cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiKey, IntPtr native_payload, IntPtr native_signature, IntPtr native_p3, IntPtr native_p4, IntPtr native_externalId, IntPtr native_p6)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var apiKey = JNIEnv.GetString (native_apiKey, JniHandleOwnership.DoNotTransfer);
			var payload = JNIEnv.GetString (native_payload, JniHandleOwnership.DoNotTransfer);
			var signature = JNIEnv.GetString (native_signature, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p3, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p4, JniHandleOwnership.DoNotTransfer);
			var externalId = JNIEnv.GetString (native_externalId, JniHandleOwnership.DoNotTransfer);
			var p6 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p6, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authenticate (apiKey!, payload!, signature!, p3, p4, externalId!, p6!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Authenticate (string apiKey, string payload, string signature, global::Java.Lang.Long? p3, global::Java.Lang.Long? p4, string externalId, global::Kotlin.Coroutines.IContinuation p6)
		{
			if (id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_apiKey = JNIEnv.NewString ((string?)apiKey);
			IntPtr native_payload = JNIEnv.NewString ((string?)payload);
			IntPtr native_signature = JNIEnv.NewString ((string?)signature);
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			JValue* __args = stackalloc JValue [7];
			__args [0] = new JValue (native_apiKey);
			__args [1] = new JValue (native_payload);
			__args [2] = new JValue (native_signature);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			__args [5] = new JValue (native_externalId);
			__args [6] = new JValue ((p6 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p6).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_apiKey);
			JNIEnv.DeleteLocalRef (native_payload);
			JNIEnv.DeleteLocalRef (native_signature);
			JNIEnv.DeleteLocalRef (native_externalId);
			return __ret;
		}

		static Delegate? cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Handler ()
		{
			if (cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ == null)
				cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_V (n_Authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_));
			return cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_;
		}

		static void n_Authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiKey, IntPtr native_payload, IntPtr native_signature, IntPtr native_externalId, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var apiKey = JNIEnv.GetString (native_apiKey, JniHandleOwnership.DoNotTransfer);
			var payload = JNIEnv.GetString (native_payload, JniHandleOwnership.DoNotTransfer);
			var signature = JNIEnv.GetString (native_signature, JniHandleOwnership.DoNotTransfer);
			var externalId = JNIEnv.GetString (native_externalId, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback?)global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.Authenticate (apiKey!, payload!, signature!, externalId!, @callback!);
		}
#pragma warning restore 0169

		IntPtr id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_;
		public unsafe void Authenticate (string apiKey, string payload, string signature, string externalId, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback @callback)
		{
			if (id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ == IntPtr.Zero)
				id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkCallback;)V");
			IntPtr native_apiKey = JNIEnv.NewString ((string?)apiKey);
			IntPtr native_payload = JNIEnv.NewString ((string?)payload);
			IntPtr native_signature = JNIEnv.NewString ((string?)signature);
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_apiKey);
			__args [1] = new JValue (native_payload);
			__args [2] = new JValue (native_signature);
			__args [3] = new JValue (native_externalId);
			__args [4] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_, __args);
			JNIEnv.DeleteLocalRef (native_apiKey);
			JNIEnv.DeleteLocalRef (native_payload);
			JNIEnv.DeleteLocalRef (native_signature);
			JNIEnv.DeleteLocalRef (native_externalId);
		}

		static Delegate? cb_clearAuthentication;
#pragma warning disable 0169
		static Delegate GetClearAuthenticationHandler ()
		{
			if (cb_clearAuthentication == null)
				cb_clearAuthentication = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ClearAuthentication));
			return cb_clearAuthentication;
		}

		static void n_ClearAuthentication (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ClearAuthentication ();
		}
#pragma warning restore 0169

		IntPtr id_clearAuthentication;
		public unsafe void ClearAuthentication ()
		{
			if (id_clearAuthentication == IntPtr.Zero)
				id_clearAuthentication = JNIEnv.GetMethodID (class_ref, "clearAuthentication", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearAuthentication);
		}

		static Delegate? cb_generatePayload;
#pragma warning disable 0169
		static Delegate GetGeneratePayloadHandler ()
		{
			if (cb_generatePayload == null)
				cb_generatePayload = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GeneratePayload));
			return cb_generatePayload;
		}

		static IntPtr n_GeneratePayload (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.GeneratePayload ());
		}
#pragma warning restore 0169

		IntPtr id_generatePayload;
		public unsafe string GeneratePayload ()
		{
			if (id_generatePayload == IntPtr.Zero)
				id_generatePayload = JNIEnv.GetMethodID (class_ref, "generatePayload", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generatePayload), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetHandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_ == null)
				cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLL_L (n_HandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_));
			return cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_HandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiKey, IntPtr native_externalId, IntPtr native_signatureProvider, IntPtr native__callback, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var apiKey = JNIEnv.GetString (native_apiKey, JniHandleOwnership.DoNotTransfer);
			var externalId = JNIEnv.GetString (native_externalId, JniHandleOwnership.DoNotTransfer);
			var signatureProvider = (global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider?)global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider> (native_signatureProvider, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback?)global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HandleAuthentication (apiKey!, externalId!, signatureProvider!, @callback!, p4!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? HandleAuthentication (string apiKey, string externalId, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider signatureProvider, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback @callback, global::Kotlin.Coroutines.IContinuation p4)
		{
			if (id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "handleAuthentication", "(Ljava/lang/String;Ljava/lang/String;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkSignatureProvider;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkCallback;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_apiKey = JNIEnv.NewString ((string?)apiKey);
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_apiKey);
			__args [1] = new JValue (native_externalId);
			__args [2] = new JValue ((signatureProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signatureProvider).Handle);
			__args [3] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_apiKey);
			JNIEnv.DeleteLocalRef (native_externalId);
			return __ret;
		}

		static Delegate? cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetHandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_ == null)
				cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLL_L (n_HandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_));
			return cb_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_HandleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_apiKey, IntPtr native_externalId, IntPtr native_signatureProvider, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var apiKey = JNIEnv.GetString (native_apiKey, JniHandleOwnership.DoNotTransfer);
			var externalId = JNIEnv.GetString (native_externalId, JniHandleOwnership.DoNotTransfer);
			var signatureProvider = (global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider?)global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider> (native_signatureProvider, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HandleAuthentication (apiKey!, externalId!, signatureProvider!, p3!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? HandleAuthentication (string apiKey, string externalId, global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider signatureProvider, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "handleAuthentication", "(Ljava/lang/String;Ljava/lang/String;Lcom/truvideo/sdk/core/interfaces/TruvideoSdkSignatureProvider;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_apiKey = JNIEnv.NewString ((string?)apiKey);
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_apiKey);
			__args [1] = new JValue (native_externalId);
			__args [2] = new JValue ((signatureProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) signatureProvider).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_handleAuthentication_Ljava_lang_String_Ljava_lang_String_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkSignatureProvider_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_apiKey);
			JNIEnv.DeleteLocalRef (native_externalId);
			return __ret;
		}

		static Delegate? cb_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_;
#pragma warning disable 0169
		static Delegate GetInitAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_Handler ()
		{
			if (cb_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ == null)
				cb_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_InitAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_));
			return cb_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_;
		}

		static void n_InitAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var @callback = (global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback?)global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.InitAuthentication (@callback!);
		}
#pragma warning restore 0169

		IntPtr id_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_;
		public unsafe void InitAuthentication (global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkCallback @callback)
		{
			if (id_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ == IntPtr.Zero)
				id_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_ = JNIEnv.GetMethodID (class_ref, "initAuthentication", "(Lcom/truvideo/sdk/core/interfaces/TruvideoSdkCallback;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initAuthentication_Lcom_truvideo_sdk_core_interfaces_TruvideoSdkCallback_, __args);
		}

		static Delegate? cb_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetInitAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_ == null)
				cb_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_L (n_InitAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_));
			return cb_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_InitAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdk> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.InitAuthentication (p0, p1, p2!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? InitAuthentication (global::Java.Lang.Long? p0, global::Java.Lang.Long? p1, global::Kotlin.Coroutines.IContinuation p2)
		{
			if (id_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "initAuthentication", "(Ljava/lang/Long;Ljava/lang/Long;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_initAuthentication_Ljava_lang_Long_Ljava_lang_Long_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
