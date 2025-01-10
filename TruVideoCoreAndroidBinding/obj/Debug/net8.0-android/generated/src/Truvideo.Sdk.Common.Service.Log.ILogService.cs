using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Service.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']"
	[Register ("truvideo/sdk/common/service/log/LogService", "", "Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker")]
	public partial interface ILogService : IJavaObject, IJavaPeerable {
		string CurrentBufferFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='getCurrentBufferFilePath' and count(parameter)=0]"
			[Register ("getCurrentBufferFilePath", "()Ljava/lang/String;", "GetGetCurrentBufferFilePathHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		long CurrentBufferFileSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='getCurrentBufferFileSize' and count(parameter)=0]"
			[Register ("getCurrentBufferFileSize", "()J", "GetGetCurrentBufferFileSizeHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		string DirectoryPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='getDirectoryPath' and count(parameter)=0]"
			[Register ("getDirectoryPath", "()Ljava/lang/String;", "GetGetDirectoryPathHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		string ErrorDirectoryPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='getErrorDirectoryPath' and count(parameter)=0]"
			[Register ("getErrorDirectoryPath", "()Ljava/lang/String;", "GetGetErrorDirectoryPathHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler? Handler {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='getHandler' and count(parameter)=0]"
			[Register ("getHandler", "()Ltruvideo/sdk/common/service/log/interfaces/LogFileUploadHandler;", "GetGetHandlerHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 

			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='setHandler' and count(parameter)=1 and parameter[1][@type='truvideo.sdk.common.service.log.interfaces.LogFileUploadHandler']]"
			[Register ("setHandler", "(Ltruvideo/sdk/common/service/log/interfaces/LogFileUploadHandler;)V", "GetSetHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_Handler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			set; 
		}

		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow NextRunAt {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='getNextRunAt' and count(parameter)=0]"
			[Register ("getNextRunAt", "()Lkotlinx/coroutines/flow/StateFlow;", "GetGetNextRunAtHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		string PendingDirectoryPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='getPendingDirectoryPath' and count(parameter)=0]"
			[Register ("getPendingDirectoryPath", "()Ljava/lang/String;", "GetGetPendingDirectoryPathHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='add' and count(parameter)=1 and parameter[1][@type='truvideo.sdk.common.model.TruvideoSdkLog']]"
		[Register ("add", "(Ltruvideo/sdk/common/model/TruvideoSdkLog;)V", "GetAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Handler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		void Add (global::Truvideo.Sdk.Common.Model.TruvideoSdkLog log);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='addMultiple' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;truvideo.sdk.common.model.TruvideoSdkLog&gt;']]"
		[Register ("addMultiple", "(Ljava/util/List;)V", "GetAddMultiple_Ljava_util_List_Handler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		void AddMultiple (global::System.Collections.Generic.IList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog> logs);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='deleteAll' and count(parameter)=0]"
		[Register ("deleteAll", "()V", "GetDeleteAllHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		void DeleteAll ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='truvideo.sdk.common.service.log.interfaces.LogFileUploadHandler']]"
		[Register ("initialize", "(Ltruvideo/sdk/common/service/log/interfaces/LogFileUploadHandler;)V", "GetInitialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_Handler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		void Initialize (global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler handler);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='isInitialized' and count(parameter)=0]"
		[Register ("isInitialized", "()Lkotlinx/coroutines/flow/StateFlow;", "GetIsInitializedHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsInitialized ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='isRunning' and count(parameter)=0]"
		[Register ("isRunning", "()Lkotlinx/coroutines/flow/StateFlow;", "GetIsRunningHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsRunning ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='isStarted' and count(parameter)=0]"
		[Register ("isStarted", "()Lkotlinx/coroutines/flow/StateFlow;", "GetIsStartedHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsStarted ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		void Start ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		void Stop ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='suspendAdd' and count(parameter)=2 and parameter[1][@type='truvideo.sdk.common.model.TruvideoSdkLog'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("suspendAdd", "(Ltruvideo/sdk/common/model/TruvideoSdkLog;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetSuspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? SuspendAdd (global::Truvideo.Sdk.Common.Model.TruvideoSdkLog log, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='suspendAddMultiple' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;truvideo.sdk.common.model.TruvideoSdkLog&gt;'] and parameter[2][@type='kotlin.coroutines.Continuation&lt;? super kotlin.Unit&gt;']]"
		[Register ("suspendAddMultiple", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetSuspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? SuspendAddMultiple (global::System.Collections.Generic.IList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog> logs, global::Kotlin.Coroutines.IContinuation p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.log']/interface[@name='LogService']/method[@name='sync' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("sync", "(Z)V", "GetSync_ZHandler:Truvideo.Sdk.Common.Service.Log.ILogServiceInvoker, TruVideoCoreAndroidBinding")]
		void Sync (bool includeErrorFiles);

		// Metadata.xml XPath class reference: path="/api/package[@name='truvideo.sdk.common.service.log']/class[@name='LogService.DefaultImpls']"
		[global::Android.Runtime.Register ("truvideo/sdk/common/service/log/LogService$DefaultImpls", DoNotGenerateAcw=true)]
		public sealed partial class DefaultImpls : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/log/LogService$DefaultImpls", typeof (DefaultImpls));

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

	[global::Android.Runtime.Register ("truvideo/sdk/common/service/log/LogService", DoNotGenerateAcw=true)]
	internal partial class ILogServiceInvoker : global::Java.Lang.Object, ILogService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/log/LogService", typeof (ILogServiceInvoker));

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

		public static ILogService? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.service.log.LogService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_getCurrentBufferFilePath;
#pragma warning disable 0169
		static Delegate GetGetCurrentBufferFilePathHandler ()
		{
			if (cb_getCurrentBufferFilePath == null)
				cb_getCurrentBufferFilePath = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetCurrentBufferFilePath));
			return cb_getCurrentBufferFilePath;
		}

		static IntPtr n_GetCurrentBufferFilePath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.CurrentBufferFilePath);
		}
#pragma warning restore 0169

		IntPtr id_getCurrentBufferFilePath;
		public unsafe string CurrentBufferFilePath {
			get {
				if (id_getCurrentBufferFilePath == IntPtr.Zero)
					id_getCurrentBufferFilePath = JNIEnv.GetMethodID (class_ref, "getCurrentBufferFilePath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBufferFilePath), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getCurrentBufferFileSize;
#pragma warning disable 0169
		static Delegate GetGetCurrentBufferFileSizeHandler ()
		{
			if (cb_getCurrentBufferFileSize == null)
				cb_getCurrentBufferFileSize = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_J (n_GetCurrentBufferFileSize));
			return cb_getCurrentBufferFileSize;
		}

		static long n_GetCurrentBufferFileSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return __this.CurrentBufferFileSize;
		}
#pragma warning restore 0169

		IntPtr id_getCurrentBufferFileSize;
		public unsafe long CurrentBufferFileSize {
			get {
				if (id_getCurrentBufferFileSize == IntPtr.Zero)
					id_getCurrentBufferFileSize = JNIEnv.GetMethodID (class_ref, "getCurrentBufferFileSize", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getCurrentBufferFileSize);
			}
		}

		static Delegate? cb_getDirectoryPath;
#pragma warning disable 0169
		static Delegate GetGetDirectoryPathHandler ()
		{
			if (cb_getDirectoryPath == null)
				cb_getDirectoryPath = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetDirectoryPath));
			return cb_getDirectoryPath;
		}

		static IntPtr n_GetDirectoryPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.DirectoryPath);
		}
#pragma warning restore 0169

		IntPtr id_getDirectoryPath;
		public unsafe string DirectoryPath {
			get {
				if (id_getDirectoryPath == IntPtr.Zero)
					id_getDirectoryPath = JNIEnv.GetMethodID (class_ref, "getDirectoryPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDirectoryPath), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getErrorDirectoryPath;
#pragma warning disable 0169
		static Delegate GetGetErrorDirectoryPathHandler ()
		{
			if (cb_getErrorDirectoryPath == null)
				cb_getErrorDirectoryPath = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetErrorDirectoryPath));
			return cb_getErrorDirectoryPath;
		}

		static IntPtr n_GetErrorDirectoryPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.ErrorDirectoryPath);
		}
#pragma warning restore 0169

		IntPtr id_getErrorDirectoryPath;
		public unsafe string ErrorDirectoryPath {
			get {
				if (id_getErrorDirectoryPath == IntPtr.Zero)
					id_getErrorDirectoryPath = JNIEnv.GetMethodID (class_ref, "getErrorDirectoryPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getErrorDirectoryPath), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getHandler;
#pragma warning disable 0169
		static Delegate GetGetHandlerHandler ()
		{
			if (cb_getHandler == null)
				cb_getHandler = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetHandler));
			return cb_getHandler;
		}

		static IntPtr n_GetHandler (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.Handler);
		}
#pragma warning restore 0169

		static Delegate? cb_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_;
#pragma warning disable 0169
		static Delegate GetSetHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_Handler ()
		{
			if (cb_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ == null)
				cb_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_SetHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_));
			return cb_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_;
		}

		static void n_SetHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var value = (global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler?)global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Handler = value;
		}
#pragma warning restore 0169

		IntPtr id_getHandler;
		IntPtr id_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_;
		public unsafe global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler? Handler {
			get {
				if (id_getHandler == IntPtr.Zero)
					id_getHandler = JNIEnv.GetMethodID (class_ref, "getHandler", "()Ltruvideo/sdk/common/service/log/interfaces/LogFileUploadHandler;");
				return global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHandler), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ == IntPtr.Zero)
					id_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ = JNIEnv.GetMethodID (class_ref, "setHandler", "(Ltruvideo/sdk/common/service/log/interfaces/LogFileUploadHandler;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHandler_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_, __args);
			}
		}

		static Delegate? cb_getNextRunAt;
#pragma warning disable 0169
		static Delegate GetGetNextRunAtHandler ()
		{
			if (cb_getNextRunAt == null)
				cb_getNextRunAt = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetNextRunAt));
			return cb_getNextRunAt;
		}

		static IntPtr n_GetNextRunAt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.NextRunAt);
		}
#pragma warning restore 0169

		IntPtr id_getNextRunAt;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow NextRunAt {
			get {
				if (id_getNextRunAt == IntPtr.Zero)
					id_getNextRunAt = JNIEnv.GetMethodID (class_ref, "getNextRunAt", "()Lkotlinx/coroutines/flow/StateFlow;");
				return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getNextRunAt), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_getPendingDirectoryPath;
#pragma warning disable 0169
		static Delegate GetGetPendingDirectoryPathHandler ()
		{
			if (cb_getPendingDirectoryPath == null)
				cb_getPendingDirectoryPath = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_GetPendingDirectoryPath));
			return cb_getPendingDirectoryPath;
		}

		static IntPtr n_GetPendingDirectoryPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.NewString (__this.PendingDirectoryPath);
		}
#pragma warning restore 0169

		IntPtr id_getPendingDirectoryPath;
		public unsafe string PendingDirectoryPath {
			get {
				if (id_getPendingDirectoryPath == IntPtr.Zero)
					id_getPendingDirectoryPath = JNIEnv.GetMethodID (class_ref, "getPendingDirectoryPath", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPendingDirectoryPath), JniHandleOwnership.TransferLocalRef)!;
			}
		}

		static Delegate? cb_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_;
#pragma warning disable 0169
		static Delegate GetAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Handler ()
		{
			if (cb_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_ == null)
				cb_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Add_Ltruvideo_sdk_common_model_TruvideoSdkLog_));
			return cb_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_;
		}

		static void n_Add_Ltruvideo_sdk_common_model_TruvideoSdkLog_ (IntPtr jnienv, IntPtr native__this, IntPtr native_log)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var log = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog> (native_log, JniHandleOwnership.DoNotTransfer);
			__this.Add (log!);
		}
#pragma warning restore 0169

		IntPtr id_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_;
		public unsafe void Add (global::Truvideo.Sdk.Common.Model.TruvideoSdkLog log)
		{
			if (id_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_ == IntPtr.Zero)
				id_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_ = JNIEnv.GetMethodID (class_ref, "add", "(Ltruvideo/sdk/common/model/TruvideoSdkLog;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((log == null) ? IntPtr.Zero : ((global::Java.Lang.Object) log).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ltruvideo_sdk_common_model_TruvideoSdkLog_, __args);
		}

		static Delegate? cb_addMultiple_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetAddMultiple_Ljava_util_List_Handler ()
		{
			if (cb_addMultiple_Ljava_util_List_ == null)
				cb_addMultiple_Ljava_util_List_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_AddMultiple_Ljava_util_List_));
			return cb_addMultiple_Ljava_util_List_;
		}

		static void n_AddMultiple_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var logs = global::Android.Runtime.JavaList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog>.FromJniHandle (native_logs, JniHandleOwnership.DoNotTransfer);
			__this.AddMultiple (logs!);
		}
#pragma warning restore 0169

		IntPtr id_addMultiple_Ljava_util_List_;
		public unsafe void AddMultiple (global::System.Collections.Generic.IList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog> logs)
		{
			if (id_addMultiple_Ljava_util_List_ == IntPtr.Zero)
				id_addMultiple_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "addMultiple", "(Ljava/util/List;)V");
			IntPtr native_logs = global::Android.Runtime.JavaList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog>.ToLocalJniHandle (logs);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_logs);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMultiple_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_logs);
		}

		static Delegate? cb_deleteAll;
#pragma warning disable 0169
		static Delegate GetDeleteAllHandler ()
		{
			if (cb_deleteAll == null)
				cb_deleteAll = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_DeleteAll));
			return cb_deleteAll;
		}

		static void n_DeleteAll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.DeleteAll ();
		}
#pragma warning restore 0169

		IntPtr id_deleteAll;
		public unsafe void DeleteAll ()
		{
			if (id_deleteAll == IntPtr.Zero)
				id_deleteAll = JNIEnv.GetMethodID (class_ref, "deleteAll", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAll);
		}

		static Delegate? cb_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_;
#pragma warning disable 0169
		static Delegate GetInitialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_Handler ()
		{
			if (cb_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ == null)
				cb_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_V (n_Initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_));
			return cb_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_;
		}

		static void n_Initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_handler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var handler = (global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler?)global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler> (native_handler, JniHandleOwnership.DoNotTransfer);
			__this.Initialize (handler!);
		}
#pragma warning restore 0169

		IntPtr id_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_;
		public unsafe void Initialize (global::Truvideo.Sdk.Common.Service.Log.Interfaces.ILogFileUploadHandler handler)
		{
			if (id_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ == IntPtr.Zero)
				id_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_ = JNIEnv.GetMethodID (class_ref, "initialize", "(Ltruvideo/sdk/common/service/log/interfaces/LogFileUploadHandler;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((handler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) handler).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_initialize_Ltruvideo_sdk_common_service_log_interfaces_LogFileUploadHandler_, __args);
		}

		static Delegate? cb_isInitialized;
#pragma warning disable 0169
		static Delegate GetIsInitializedHandler ()
		{
			if (cb_isInitialized == null)
				cb_isInitialized = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_IsInitialized));
			return cb_isInitialized;
		}

		static IntPtr n_IsInitialized (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IsInitialized ());
		}
#pragma warning restore 0169

		IntPtr id_isInitialized;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsInitialized ()
		{
			if (id_isInitialized == IntPtr.Zero)
				id_isInitialized = JNIEnv.GetMethodID (class_ref, "isInitialized", "()Lkotlinx/coroutines/flow/StateFlow;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isInitialized), JniHandleOwnership.TransferLocalRef)!;
		}

		static Delegate? cb_isRunning;
#pragma warning disable 0169
		static Delegate GetIsRunningHandler ()
		{
			if (cb_isRunning == null)
				cb_isRunning = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_L (n_IsRunning));
			return cb_isRunning;
		}

		static IntPtr n_IsRunning (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			return JNIEnv.ToLocalJniHandle (__this.IsRunning ());
		}
#pragma warning restore 0169

		IntPtr id_isRunning;
		public unsafe global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow IsRunning ()
		{
			if (id_isRunning == IntPtr.Zero)
				id_isRunning = JNIEnv.GetMethodID (class_ref, "isRunning", "()Lkotlinx/coroutines/flow/StateFlow;");
			return global::Java.Lang.Object.GetObject<global::Xamarin.KotlinX.Coroutines.Flow.IStateFlow> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isRunning), JniHandleOwnership.TransferLocalRef)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
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

		static Delegate? cb_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetSuspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_ == null)
				cb_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_SuspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_));
			return cb_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_SuspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_log, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var log = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog> (native_log, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SuspendAdd (log!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? SuspendAdd (global::Truvideo.Sdk.Common.Model.TruvideoSdkLog log, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "suspendAdd", "(Ltruvideo/sdk/common/model/TruvideoSdkLog;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((log == null) ? IntPtr.Zero : ((global::Java.Lang.Object) log).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_suspendAdd_Ltruvideo_sdk_common_model_TruvideoSdkLog_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate? cb_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetSuspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_ == null)
				cb_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_SuspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_));
			return cb_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_;
		}

		static IntPtr n_SuspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_logs, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var logs = global::Android.Runtime.JavaList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog>.FromJniHandle (native_logs, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SuspendAddMultiple (logs!, p1!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? SuspendAddMultiple (global::System.Collections.Generic.IList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog> logs, global::Kotlin.Coroutines.IContinuation p1)
		{
			if (id_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "suspendAddMultiple", "(Ljava/util/List;Lkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_logs = global::Android.Runtime.JavaList<global::Truvideo.Sdk.Common.Model.TruvideoSdkLog>.ToLocalJniHandle (logs);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_logs);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_suspendAddMultiple_Ljava_util_List_Lkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_logs);
			return __ret;
		}

		static Delegate? cb_sync_Z;
#pragma warning disable 0169
		static Delegate GetSync_ZHandler ()
		{
			if (cb_sync_Z == null)
				cb_sync_Z = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPZ_V (n_Sync_Z));
			return cb_sync_Z;
		}

		static void n_Sync_Z (IntPtr jnienv, IntPtr native__this, bool includeErrorFiles)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Log.ILogService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.Sync (includeErrorFiles);
		}
#pragma warning restore 0169

		IntPtr id_sync_Z;
		public unsafe void Sync (bool includeErrorFiles)
		{
			if (id_sync_Z == IntPtr.Zero)
				id_sync_Z = JNIEnv.GetMethodID (class_ref, "sync", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (includeErrorFiles);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sync_Z, __args);
		}

	}
}
