using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']"
	[Register ("truvideo/sdk/common/TruvideoSdkCommon", "", "Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker")]
	public partial interface ITruvideoSdkCommon : IJavaObject, IJavaPeerable {
		global::Truvideo.Sdk.Common.Service.Auth.IAuthService Auth {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getAuth' and count(parameter)=0]"
			[Register ("getAuth", "()Ltruvideo/sdk/common/service/auth/AuthService;", "GetGetAuthHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Model.TruvideoSdkConfiguration Configuration {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getConfiguration' and count(parameter)=0]"
			[Register ("getConfiguration", "()Ltruvideo/sdk/common/model/TruvideoSdkConfiguration;", "GetGetConfigurationHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Service.Connectivity.IConnectivityService Connectivity {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getConnectivity' and count(parameter)=0]"
			[Register ("getConnectivity", "()Ltruvideo/sdk/common/service/connectivity/ConnectivityService;", "GetGetConnectivityHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Service.Http.IHttpService Http {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getHttp' and count(parameter)=0]"
			[Register ("getHttp", "()Ltruvideo/sdk/common/service/http/HttpService;", "GetGetHttpHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Service.IP.IIpService Ip {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getIp' and count(parameter)=0]"
			[Register ("getIp", "()Ltruvideo/sdk/common/service/ip/IpService;", "GetGetIpHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService LocalStorage {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getLocalStorage' and count(parameter)=0]"
			[Register ("getLocalStorage", "()Ltruvideo/sdk/common/service/local_storage/LocalStorageService;", "GetGetLocalStorageHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Service.Log.ILogService Log {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getLog' and count(parameter)=0]"
			[Register ("getLog", "()Ltruvideo/sdk/common/service/log/LogService;", "GetGetLogHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		string Version {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common']/interface[@name='TruvideoSdkCommon']/method[@name='getVersion' and count(parameter)=0]"
			[Register ("getVersion", "()Ljava/lang/String;", "GetGetVersionHandler:Truvideo.Sdk.Common.ITruvideoSdkCommonInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/TruvideoSdkCommon", DoNotGenerateAcw=true)]
	internal partial class ITruvideoSdkCommonInvoker : global::Java.Lang.Object, ITruvideoSdkCommon {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/TruvideoSdkCommon", typeof (ITruvideoSdkCommonInvoker));

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

		public static ITruvideoSdkCommon? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITruvideoSdkCommon> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.TruvideoSdkCommon'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITruvideoSdkCommonInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getAuth;
#pragma warning disable 0169
		static Delegate GetGetAuthHandler ()
		{
			if (cb_getAuth == null)
				cb_getAuth = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetAuth));
			return cb_getAuth;
		}

		static IntPtr n_GetAuth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Auth);
		}
#pragma warning restore 0169

		IntPtr id_getAuth;
		public unsafe global::Truvideo.Sdk.Common.Service.Auth.IAuthService Auth {
			get {
				if (id_getAuth == IntPtr.Zero)
					id_getAuth = JNIEnv.GetMethodID (class_ref, "getAuth", "()Ltruvideo/sdk/common/service/auth/AuthService;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Auth.IAuthService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuth), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getConfiguration;
#pragma warning disable 0169
		static Delegate GetGetConfigurationHandler ()
		{
			if (cb_getConfiguration == null)
				cb_getConfiguration = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetConfiguration));
			return cb_getConfiguration;
		}

		static IntPtr n_GetConfiguration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Configuration);
		}
#pragma warning restore 0169

		IntPtr id_getConfiguration;
		public unsafe global::Truvideo.Sdk.Common.Model.TruvideoSdkConfiguration Configuration {
			get {
				if (id_getConfiguration == IntPtr.Zero)
					id_getConfiguration = JNIEnv.GetMethodID (class_ref, "getConfiguration", "()Ltruvideo/sdk/common/model/TruvideoSdkConfiguration;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Model.TruvideoSdkConfiguration> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfiguration), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getConnectivity;
#pragma warning disable 0169
		static Delegate GetGetConnectivityHandler ()
		{
			if (cb_getConnectivity == null)
				cb_getConnectivity = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetConnectivity));
			return cb_getConnectivity;
		}

		static IntPtr n_GetConnectivity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Connectivity);
		}
#pragma warning restore 0169

		IntPtr id_getConnectivity;
		public unsafe global::Truvideo.Sdk.Common.Service.Connectivity.IConnectivityService Connectivity {
			get {
				if (id_getConnectivity == IntPtr.Zero)
					id_getConnectivity = JNIEnv.GetMethodID (class_ref, "getConnectivity", "()Ltruvideo/sdk/common/service/connectivity/ConnectivityService;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Connectivity.IConnectivityService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConnectivity), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getHttp;
#pragma warning disable 0169
		static Delegate GetGetHttpHandler ()
		{
			if (cb_getHttp == null)
				cb_getHttp = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHttp));
			return cb_getHttp;
		}

		static IntPtr n_GetHttp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Http);
		}
#pragma warning restore 0169

		IntPtr id_getHttp;
		public unsafe global::Truvideo.Sdk.Common.Service.Http.IHttpService Http {
			get {
				if (id_getHttp == IntPtr.Zero)
					id_getHttp = JNIEnv.GetMethodID (class_ref, "getHttp", "()Ltruvideo/sdk/common/service/http/HttpService;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Http.IHttpService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHttp), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getIp;
#pragma warning disable 0169
		static Delegate GetGetIpHandler ()
		{
			if (cb_getIp == null)
				cb_getIp = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetIp));
			return cb_getIp;
		}

		static IntPtr n_GetIp (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Ip);
		}
#pragma warning restore 0169

		IntPtr id_getIp;
		public unsafe global::Truvideo.Sdk.Common.Service.IP.IIpService Ip {
			get {
				if (id_getIp == IntPtr.Zero)
					id_getIp = JNIEnv.GetMethodID (class_ref, "getIp", "()Ltruvideo/sdk/common/service/ip/IpService;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIp), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getLocalStorage;
#pragma warning disable 0169
		static Delegate GetGetLocalStorageHandler ()
		{
			if (cb_getLocalStorage == null)
				cb_getLocalStorage = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLocalStorage));
			return cb_getLocalStorage;
		}

		static IntPtr n_GetLocalStorage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LocalStorage);
		}
#pragma warning restore 0169

		IntPtr id_getLocalStorage;
		public unsafe global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService LocalStorage {
			get {
				if (id_getLocalStorage == IntPtr.Zero)
					id_getLocalStorage = JNIEnv.GetMethodID (class_ref, "getLocalStorage", "()Ltruvideo/sdk/common/service/local_storage/LocalStorageService;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalStorage), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getLog;
#pragma warning disable 0169
		static Delegate GetGetLogHandler ()
		{
			if (cb_getLog == null)
				cb_getLog = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLog));
			return cb_getLog;
		}

		static IntPtr n_GetLog (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Log);
		}
#pragma warning restore 0169

		IntPtr id_getLog;
		public unsafe global::Truvideo.Sdk.Common.Service.Log.ILogService Log {
			get {
				if (id_getLog == IntPtr.Zero)
					id_getLog = JNIEnv.GetMethodID (class_ref, "getLog", "()Ltruvideo/sdk/common/service/log/LogService;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLog), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.ITruvideoSdkCommon> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

	}
}
