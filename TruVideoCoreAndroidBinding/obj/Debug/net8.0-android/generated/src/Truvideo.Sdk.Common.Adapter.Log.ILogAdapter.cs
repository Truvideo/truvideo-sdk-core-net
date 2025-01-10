using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Adapter.Log {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.adapter.log']/interface[@name='LogAdapter']"
	[Register ("truvideo/sdk/common/adapter/log/LogAdapter", "", "Truvideo.Sdk.Common.Adapter.Log.ILogAdapterInvoker")]
	public partial interface ILogAdapter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.adapter.log']/interface[@name='LogAdapter']/method[@name='add' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='truvideo.sdk.common.model.TruvideoSdkLogSeverity']]"
		[Register ("add", "(Ljava/lang/String;Ljava/lang/String;Ltruvideo/sdk/common/model/TruvideoSdkLogSeverity;)V", "GetAdd_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_Handler:Truvideo.Sdk.Common.Adapter.Log.ILogAdapterInvoker, TruVideoCoreAndroidBinding")]
		void Add (string tag, string msg, global::Truvideo.Sdk.Common.Model.TruvideoSdkLogSeverity severity);

		// Metadata.xml XPath class reference: path="/api/package[@name='truvideo.sdk.common.adapter.log']/class[@name='LogAdapter.DefaultImpls']"
		[global::Android.Runtime.Register ("truvideo/sdk/common/adapter/log/LogAdapter$DefaultImpls", DoNotGenerateAcw=true)]
		public sealed partial class DefaultImpls : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/adapter/log/LogAdapter$DefaultImpls", typeof (DefaultImpls));

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

	[global::Android.Runtime.Register ("truvideo/sdk/common/adapter/log/LogAdapter", DoNotGenerateAcw=true)]
	internal partial class ILogAdapterInvoker : global::Java.Lang.Object, ILogAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/adapter/log/LogAdapter", typeof (ILogAdapterInvoker));

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

		public static ILogAdapter? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILogAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.adapter.log.LogAdapter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILogAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_;
#pragma warning disable 0169
		static Delegate GetAdd_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_Handler ()
		{
			if (cb_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_ == null)
				cb_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLL_V (n_Add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_));
			return cb_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_;
		}

		static void n_Add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tag, IntPtr native_msg, IntPtr native_severity)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Adapter.Log.ILogAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var tag = JNIEnv.GetString (native_tag, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			var severity = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Model.TruvideoSdkLogSeverity> (native_severity, JniHandleOwnership.DoNotTransfer);
			__this.Add (tag!, msg!, severity!);
		}
#pragma warning restore 0169

		IntPtr id_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_;
		public unsafe void Add (string tag, string msg, global::Truvideo.Sdk.Common.Model.TruvideoSdkLogSeverity severity)
		{
			if (id_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_ == IntPtr.Zero)
				id_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_ = JNIEnv.GetMethodID (class_ref, "add", "(Ljava/lang/String;Ljava/lang/String;Ltruvideo/sdk/common/model/TruvideoSdkLogSeverity;)V");
			IntPtr native_tag = JNIEnv.NewString ((string?)tag);
			IntPtr native_msg = JNIEnv.NewString ((string?)msg);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (native_tag);
			__args [1] = new JValue (native_msg);
			__args [2] = new JValue ((severity == null) ? IntPtr.Zero : ((global::Java.Lang.Object) severity).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_add_Ljava_lang_String_Ljava_lang_String_Ltruvideo_sdk_common_model_TruvideoSdkLogSeverity_, __args);
			JNIEnv.DeleteLocalRef (native_tag);
			JNIEnv.DeleteLocalRef (native_msg);
		}

	}
}
