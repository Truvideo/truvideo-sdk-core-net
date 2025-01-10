using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Truvideo.Sdk.Core.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdkSignatureProvider']"
	[Register ("com/truvideo/sdk/core/interfaces/TruvideoSdkSignatureProvider", "", "Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProviderInvoker")]
	public partial interface ITruvideoSdkSignatureProvider : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.truvideo.sdk.core.interfaces']/interface[@name='TruvideoSdkSignatureProvider']/method[@name='generateSignature' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("generateSignature", "(Ljava/lang/String;)Ljava/lang/String;", "GetGenerateSignature_Ljava_lang_String_Handler:Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProviderInvoker, TruVideoCoreAndroidBinding")]
		string GenerateSignature (string payload);

	}

	[global::Android.Runtime.Register ("com/truvideo/sdk/core/interfaces/TruvideoSdkSignatureProvider", DoNotGenerateAcw=true)]
	internal partial class ITruvideoSdkSignatureProviderInvoker : global::Java.Lang.Object, ITruvideoSdkSignatureProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/truvideo/sdk/core/interfaces/TruvideoSdkSignatureProvider", typeof (ITruvideoSdkSignatureProviderInvoker));

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

		public static ITruvideoSdkSignatureProvider? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ITruvideoSdkSignatureProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.truvideo.sdk.core.interfaces.TruvideoSdkSignatureProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ITruvideoSdkSignatureProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_generateSignature_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGenerateSignature_Ljava_lang_String_Handler ()
		{
			if (cb_generateSignature_Ljava_lang_String_ == null)
				cb_generateSignature_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPL_L (n_GenerateSignature_Ljava_lang_String_));
			return cb_generateSignature_Ljava_lang_String_;
		}

		static IntPtr n_GenerateSignature_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_payload)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Truvideo.Sdk.Core.Interfaces.ITruvideoSdkSignatureProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var payload = JNIEnv.GetString (native_payload, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateSignature (payload!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_generateSignature_Ljava_lang_String_;
		public unsafe string GenerateSignature (string payload)
		{
			if (id_generateSignature_Ljava_lang_String_ == IntPtr.Zero)
				id_generateSignature_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "generateSignature", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_payload = JNIEnv.NewString ((string?)payload);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_payload);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateSignature_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef)!;
			JNIEnv.DeleteLocalRef (native_payload);
			return __ret;
		}

	}
}
