using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Service.IP {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']"
	[Register ("truvideo/sdk/common/service/ip/IpService", "", "Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker")]
	public partial interface IIpService : IJavaObject, IJavaPeerable {
		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow Ip {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='getIp' and count(parameter)=0]"
			[Register ("getIp", "()Lkotlinx/coroutines/flow/StateFlow;", "GetGetIpHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow LastUpdated {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='getLastUpdated' and count(parameter)=0]"
			[Register ("getLastUpdated", "()Lkotlinx/coroutines/flow/StateFlow;", "GetGetLastUpdatedHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow NextUpdateAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='getNextUpdateAt' and count(parameter)=0]"
			[Register ("getNextUpdateAt", "()Lkotlinx/coroutines/flow/StateFlow;", "GetGetNextUpdateAtHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='fetch' and count(parameter)=0]"
		[Register ("fetch", "()V", "GetFetchHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
		void Fetch ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='isFetching' and count(parameter)=0]"
		[Register ("isFetching", "()Lkotlinx/coroutines/flow/StateFlow;", "GetIsFetchingHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsFetching ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='isStarted' and count(parameter)=0]"
		[Register ("isStarted", "()Lkotlinx/coroutines/flow/StateFlow;", "GetIsStartedHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.ip']/interface[@name='IpService']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Truvideo.Sdk.Common.Service.IP.IIpServiceInvoker, TruVideoCoreAndroidBinding")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/service/ip/IpService", DoNotGenerateAcw=true)]
	internal partial class IIpServiceInvoker : global::Java.Lang.Object, IIpService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/ip/IpService", typeof (IIpServiceInvoker));

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

		public static IIpService? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIpService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.service.ip.IpService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIpServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Ip);
		}
#pragma warning restore 0169

		IntPtr id_getIp;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow Ip {
			get {
				if (id_getIp == IntPtr.Zero)
					id_getIp = JNIEnv.GetMethodID (class_ref, "getIp", "()Lkotlinx/coroutines/flow/StateFlow;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIp), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getLastUpdated;
#pragma warning disable 0169
		static Delegate GetGetLastUpdatedHandler ()
		{
			if (cb_getLastUpdated == null)
				cb_getLastUpdated = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetLastUpdated));
			return cb_getLastUpdated;
		}

		static IntPtr n_GetLastUpdated (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.LastUpdated);
		}
#pragma warning restore 0169

		IntPtr id_getLastUpdated;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow LastUpdated {
			get {
				if (id_getLastUpdated == IntPtr.Zero)
					id_getLastUpdated = JNIEnv.GetMethodID (class_ref, "getLastUpdated", "()Lkotlinx/coroutines/flow/StateFlow;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLastUpdated), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getNextUpdateAt;
#pragma warning disable 0169
		static Delegate GetGetNextUpdateAtHandler ()
		{
			if (cb_getNextUpdateAt == null)
				cb_getNextUpdateAt = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNextUpdateAt));
			return cb_getNextUpdateAt;
		}

		static IntPtr n_GetNextUpdateAt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NextUpdateAt);
		}
#pragma warning restore 0169

		IntPtr id_getNextUpdateAt;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow NextUpdateAt {
			get {
				if (id_getNextUpdateAt == IntPtr.Zero)
					id_getNextUpdateAt = JNIEnv.GetMethodID (class_ref, "getNextUpdateAt", "()Lkotlinx/coroutines/flow/StateFlow;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextUpdateAt), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_fetch;
#pragma warning disable 0169
		static Delegate GetFetchHandler ()
		{
			if (cb_fetch == null)
				cb_fetch = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Fetch));
			return cb_fetch;
		}

		static void n_Fetch (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Fetch ();
		}
#pragma warning restore 0169

		IntPtr id_fetch;
		public unsafe void Fetch ()
		{
			if (id_fetch == IntPtr.Zero)
				id_fetch = JNIEnv.GetMethodID (class_ref, "fetch", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_fetch);
		}

		static Delegate? cb_isFetching;
#pragma warning disable 0169
		static Delegate GetIsFetchingHandler ()
		{
			if (cb_isFetching == null)
				cb_isFetching = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_IsFetching));
			return cb_isFetching;
		}

		static IntPtr n_IsFetching (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IsFetching ());
		}
#pragma warning restore 0169

		IntPtr id_isFetching;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsFetching ()
		{
			if (id_isFetching == IntPtr.Zero)
				id_isFetching = JNIEnv.GetMethodID (class_ref, "isFetching", "()Lkotlinx/coroutines/flow/StateFlow;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isFetching), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_IsStarted));
			return cb_isStarted;
		}

		static IntPtr n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IsStarted ());
		}
#pragma warning restore 0169

		IntPtr id_isStarted;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsStarted ()
		{
			if (id_isStarted == IntPtr.Zero)
				id_isStarted = JNIEnv.GetMethodID (class_ref, "isStarted", "()Lkotlinx/coroutines/flow/StateFlow;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isStarted), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Start));
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Start ();
		}
#pragma warning restore 0169

		IntPtr id_start;
		public unsafe void Start ()
		{
			if (id_start == IntPtr.Zero)
				id_start = JNIEnv.GetMethodID (class_ref, "start", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start);
		}

		static Delegate? cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_Stop));
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.IP.IIpService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}
}
