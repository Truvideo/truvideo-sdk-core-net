using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Service.Auth {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']"
	[Register ("truvideo/sdk/common/service/auth/AuthService", "", "Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker")]
	public partial interface IAuthService : IJavaObject, IJavaPeerable {
		string ApiKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='getApiKey' and count(parameter)=0]"
			[Register ("getApiKey", "()Ljava/lang/String;", "GetGetApiKeyHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Model.TruvideoSdkAuthentication? Authentication {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='getAuthentication' and count(parameter)=0]"
			[Register ("getAuthentication", "()Ltruvideo/sdk/common/model/TruvideoSdkAuthentication;", "GetGetAuthenticationHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		bool IsAuthenticated {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='isAuthenticated' and count(parameter)=0]"
			[Register ("isAuthenticated", "()Z", "GetIsAuthenticatedHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		bool IsAuthenticationExpired {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='isAuthenticationExpired' and count(parameter)=0]"
			[Register ("isAuthenticationExpired", "()Z", "GetIsAuthenticationExpiredHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		bool IsInValidPeriod {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='isInValidPeriod' and count(parameter)=0]"
			[Register ("isInValidPeriod", "()Z", "GetIsInValidPeriodHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		bool IsInitialized {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='isInitialized' and count(parameter)=0]"
			[Register ("isInitialized", "()Z", "GetIsInitializedHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Model.TruvideoSdkSettings? Settings {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='getSettings' and count(parameter)=0]"
			[Register ("getSettings", "()Ltruvideo/sdk/common/model/TruvideoSdkSettings;", "GetGetSettingsHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='authenticate' and count(parameter)=8 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.Long'] and parameter[6][@type='java.lang.Long'] and parameter[7][@type='java.lang.String'] and parameter[8][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("authenticate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Authenticate (string baseUrl, string apiKey, string payload, string signature, global::Java.Lang.Long? p4, global::Java.Lang.Long? p5, string externalId, global::Kotlin.Coroutines.IContinuation p7);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='generatePayload' and count(parameter)=0]"
		[Register ("generatePayload", "()Ljava/lang/String;", "GetGeneratePayloadHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		string GeneratePayload ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='init' and count(parameter)=4 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='boolean'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("init", "(Ljava/lang/Long;Ljava/lang/Long;ZLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetInit_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Init (global::Java.Lang.Long? p0, global::Java.Lang.Long? p1, bool forceRefresh, global::Kotlin.Coroutines.IContinuation p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='refresh' and count(parameter)=4 and parameter[1][@type='java.lang.Long'] and parameter[2][@type='java.lang.Long'] and parameter[3][@type='boolean'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("refresh", "(Ljava/lang/Long;Ljava/lang/Long;ZLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetRefresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Refresh (global::Java.Lang.Long? p0, global::Java.Lang.Long? p1, bool forceRefresh, global::Kotlin.Coroutines.IContinuation p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='throwAuthenticationRequiredException' and count(parameter)=0]"
		[Register ("throwAuthenticationRequiredException", "()V", "GetThrowAuthenticationRequiredExceptionHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		void ThrowAuthenticationRequiredException ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='throwException' and count(parameter)=0]"
		[Register ("throwException", "()V", "GetThrowExceptionHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		void ThrowException ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='throwFailReachServerException' and count(parameter)=0]"
		[Register ("throwFailReachServerException", "()V", "GetThrowFailReachServerExceptionHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		void ThrowFailReachServerException ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='throwNonInitializedException' and count(parameter)=0]"
		[Register ("throwNonInitializedException", "()V", "GetThrowNonInitializedExceptionHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		void ThrowNonInitializedException ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='throwUnauthorizedException' and count(parameter)=0]"
		[Register ("throwUnauthorizedException", "()V", "GetThrowUnauthorizedExceptionHandler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		void ThrowUnauthorizedException ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/interface[@name='AuthService']/method[@name='throwUnauthorizedException2' and count(parameter)=0]"
		[Register ("throwUnauthorizedException2", "()V", "GetThrowUnauthorizedException2Handler:Truvideo.Sdk.Common.Service.Auth.IAuthServiceInvoker, TruVideoCoreAndroidBinding")]
		void ThrowUnauthorizedException2 ();

		// Metadata.xml XPath class reference: path="/api/package[@name='truvideo.sdk.common.service.auth']/class[@name='AuthService.DefaultImpls']"
		[global::Android.Runtime.Register ("truvideo/sdk/common/service/auth/AuthService$DefaultImpls", DoNotGenerateAcw=true)]
		public sealed partial class DefaultImpls : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/auth/AuthService$DefaultImpls", typeof (DefaultImpls));

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

	[global::Android.Runtime.Register ("truvideo/sdk/common/service/auth/AuthService", DoNotGenerateAcw=true)]
	internal partial class IAuthServiceInvoker : global::Java.Lang.Object, IAuthService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/auth/AuthService", typeof (IAuthServiceInvoker));

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

		public static IAuthService? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAuthService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.service.auth.AuthService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAuthServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_getAuthentication;
#pragma warning disable 0169
		static Delegate GetGetAuthenticationHandler ()
		{
			if (cb_getAuthentication == null)
				cb_getAuthentication = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAuthentication));
			return cb_getAuthentication;
		}

		static IntPtr n_GetAuthentication (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Authentication);
		}
#pragma warning restore 0169

		IntPtr id_getAuthentication;
		public unsafe global::Truvideo.Sdk.Common.Model.TruvideoSdkAuthentication? Authentication {
			get {
				if (id_getAuthentication == IntPtr.Zero)
					id_getAuthentication = JNIEnv.GetMethodID (class_ref, "getAuthentication", "()Ltruvideo/sdk/common/model/TruvideoSdkAuthentication;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Model.TruvideoSdkAuthentication> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthentication), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_isInValidPeriod;
#pragma warning disable 0169
		static Delegate GetIsInValidPeriodHandler ()
		{
			if (cb_isInValidPeriod == null)
				cb_isInValidPeriod = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsInValidPeriod));
			return cb_isInValidPeriod;
		}

		static bool n_IsInValidPeriod (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsInValidPeriod;
		}
#pragma warning restore 0169

		IntPtr id_isInValidPeriod;
		public unsafe bool IsInValidPeriod {
			get {
				if (id_isInValidPeriod == IntPtr.Zero)
					id_isInValidPeriod = JNIEnv.GetMethodID (class_ref, "isInValidPeriod", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInValidPeriod);
			}
		}

		static Delegate? cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_Z (n_IsInitialized));
			return cb_isInitialized;
		}

		static bool n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.IsInitialized;
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe bool IsInitialized {
			get {
				if (id_isInitialized == IntPtr.Zero)
					id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized);
			}
		}

		static Delegate? cb_getSettings;
#pragma warning disable 0169
		static Delegate GetGetSettingsHandler ()
		{
			if (cb_getSettings == null)
				cb_getSettings = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetSettings));
			return cb_getSettings;
		}

		static IntPtr n_GetSettings (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Settings);
		}
#pragma warning restore 0169

		IntPtr id_getSettings;
		public unsafe global::Truvideo.Sdk.Common.Model.TruvideoSdkSettings? Settings {
			get {
				if (id_getSettings == IntPtr.Zero)
					id_getSettings = JNIEnv.GetMethodID (class_ref, "getSettings", "()Ltruvideo/sdk/common/model/TruvideoSdkSettings;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Model.TruvideoSdkSettings> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSettings), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate? cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetAuthenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == null)
				cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLLLLLL_L (n_Authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_));
			return cb_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseUrl, IntPtr native_apiKey, IntPtr native_payload, IntPtr native_signature, IntPtr native_p4, IntPtr native_p5, IntPtr native_externalId, IntPtr native_p7)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var baseUrl = JNIEnv.GetString (native_baseUrl, JniHandleOwnership.DoNotTransfer);
			var apiKey = JNIEnv.GetString (native_apiKey, JniHandleOwnership.DoNotTransfer);
			var payload = JNIEnv.GetString (native_payload, JniHandleOwnership.DoNotTransfer);
			var signature = JNIEnv.GetString (native_signature, JniHandleOwnership.DoNotTransfer);
			var p4 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p4, JniHandleOwnership.DoNotTransfer);
			var p5 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p5, JniHandleOwnership.DoNotTransfer);
			var externalId = JNIEnv.GetString (native_externalId, JniHandleOwnership.DoNotTransfer);
			var p7 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p7, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Authenticate (baseUrl!, apiKey!, payload!, signature!, p4, p5, externalId!, p7!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Authenticate (string baseUrl, string apiKey, string payload, string signature, global::Java.Lang.Long? p4, global::Java.Lang.Long? p5, string externalId, global::Kotlin.Coroutines.IContinuation p7)
		{
			if (id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "authenticate", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/Long;Ljava/lang/Long;Ljava/lang/String;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_baseUrl = JNIEnv.NewString ((string?)baseUrl);
			IntPtr native_apiKey = JNIEnv.NewString ((string?)apiKey);
			IntPtr native_payload = JNIEnv.NewString ((string?)payload);
			IntPtr native_signature = JNIEnv.NewString ((string?)signature);
			IntPtr native_externalId = JNIEnv.NewString ((string?)externalId);
			JValue* __args = stackalloc JValue [8];
			__args [0] = new JValue (native_baseUrl);
			__args [1] = new JValue (native_apiKey);
			__args [2] = new JValue (native_payload);
			__args [3] = new JValue (native_signature);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			__args [6] = new JValue (native_externalId);
			__args [7] = new JValue ((p7 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p7).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_authenticate_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Ljava_lang_Long_Ljava_lang_Long_Ljava_lang_String_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_baseUrl);
			JNIEnv.DeleteLocalRef (native_apiKey);
			JNIEnv.DeleteLocalRef (native_payload);
			JNIEnv.DeleteLocalRef (native_signature);
			JNIEnv.DeleteLocalRef (native_externalId);
			return __ret;
		}

		static Delegate? cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Clear));
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetInit_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ == null)
				cb_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZL_L (n_Init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_));
			return cb_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool forceRefresh, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Init (p0, p1, forceRefresh, p3!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Init (global::Java.Lang.Long? p0, global::Java.Lang.Long? p1, bool forceRefresh, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "init", "(Ljava/lang/Long;Ljava/lang/Long;ZLkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (forceRefresh);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_init_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetRefresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ == null)
				cb_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZL_L (n_Refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_));
			return cb_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, bool forceRefresh, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Long> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Refresh (p0, p1, forceRefresh, p3!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Refresh (global::Java.Lang.Long? p0, global::Java.Lang.Long? p1, bool forceRefresh, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "refresh", "(Ljava/lang/Long;Ljava/lang/Long;ZLkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (forceRefresh);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_refresh_Ljava_lang_Long_Ljava_lang_Long_ZLkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_throwAuthenticationRequiredException;
#pragma warning disable 0169
		static Delegate GetThrowAuthenticationRequiredExceptionHandler ()
		{
			if (cb_throwAuthenticationRequiredException == null)
				cb_throwAuthenticationRequiredException = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ThrowAuthenticationRequiredException));
			return cb_throwAuthenticationRequiredException;
		}

		static void n_ThrowAuthenticationRequiredException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ThrowAuthenticationRequiredException ();
		}
#pragma warning restore 0169

		IntPtr id_throwAuthenticationRequiredException;
		public unsafe void ThrowAuthenticationRequiredException ()
		{
			if (id_throwAuthenticationRequiredException == IntPtr.Zero)
				id_throwAuthenticationRequiredException = JNIEnv.GetMethodID (class_ref, "throwAuthenticationRequiredException", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_throwAuthenticationRequiredException);
		}

		static Delegate? cb_throwException;
#pragma warning disable 0169
		static Delegate GetThrowExceptionHandler ()
		{
			if (cb_throwException == null)
				cb_throwException = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ThrowException));
			return cb_throwException;
		}

		static void n_ThrowException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ThrowException ();
		}
#pragma warning restore 0169

		IntPtr id_throwException;
		public unsafe void ThrowException ()
		{
			if (id_throwException == IntPtr.Zero)
				id_throwException = JNIEnv.GetMethodID (class_ref, "throwException", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_throwException);
		}

		static Delegate? cb_throwFailReachServerException;
#pragma warning disable 0169
		static Delegate GetThrowFailReachServerExceptionHandler ()
		{
			if (cb_throwFailReachServerException == null)
				cb_throwFailReachServerException = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ThrowFailReachServerException));
			return cb_throwFailReachServerException;
		}

		static void n_ThrowFailReachServerException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ThrowFailReachServerException ();
		}
#pragma warning restore 0169

		IntPtr id_throwFailReachServerException;
		public unsafe void ThrowFailReachServerException ()
		{
			if (id_throwFailReachServerException == IntPtr.Zero)
				id_throwFailReachServerException = JNIEnv.GetMethodID (class_ref, "throwFailReachServerException", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_throwFailReachServerException);
		}

		static Delegate? cb_throwNonInitializedException;
#pragma warning disable 0169
		static Delegate GetThrowNonInitializedExceptionHandler ()
		{
			if (cb_throwNonInitializedException == null)
				cb_throwNonInitializedException = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ThrowNonInitializedException));
			return cb_throwNonInitializedException;
		}

		static void n_ThrowNonInitializedException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ThrowNonInitializedException ();
		}
#pragma warning restore 0169

		IntPtr id_throwNonInitializedException;
		public unsafe void ThrowNonInitializedException ()
		{
			if (id_throwNonInitializedException == IntPtr.Zero)
				id_throwNonInitializedException = JNIEnv.GetMethodID (class_ref, "throwNonInitializedException", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_throwNonInitializedException);
		}

		static Delegate? cb_throwUnauthorizedException;
#pragma warning disable 0169
		static Delegate GetThrowUnauthorizedExceptionHandler ()
		{
			if (cb_throwUnauthorizedException == null)
				cb_throwUnauthorizedException = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ThrowUnauthorizedException));
			return cb_throwUnauthorizedException;
		}

		static void n_ThrowUnauthorizedException (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ThrowUnauthorizedException ();
		}
#pragma warning restore 0169

		IntPtr id_throwUnauthorizedException;
		public unsafe void ThrowUnauthorizedException ()
		{
			if (id_throwUnauthorizedException == IntPtr.Zero)
				id_throwUnauthorizedException = JNIEnv.GetMethodID (class_ref, "throwUnauthorizedException", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_throwUnauthorizedException);
		}

		static Delegate? cb_throwUnauthorizedException2;
#pragma warning disable 0169
		static Delegate GetThrowUnauthorizedException2Handler ()
		{
			if (cb_throwUnauthorizedException2 == null)
				cb_throwUnauthorizedException2 = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_ThrowUnauthorizedException2));
			return cb_throwUnauthorizedException2;
		}

		static void n_ThrowUnauthorizedException2 (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.ThrowUnauthorizedException2 ();
		}
#pragma warning restore 0169

		IntPtr id_throwUnauthorizedException2;
		public unsafe void ThrowUnauthorizedException2 ()
		{
			if (id_throwUnauthorizedException2 == IntPtr.Zero)
				id_throwUnauthorizedException2 = JNIEnv.GetMethodID (class_ref, "throwUnauthorizedException2", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_throwUnauthorizedException2);
		}

	}
}
