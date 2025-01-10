using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Service.Local_storage {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.service.local_storage']/interface[@name='LocalStorageService']"
	[Register ("truvideo/sdk/common/service/local_storage/LocalStorageService", "", "Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageServiceInvoker")]
	public partial interface ILocalStorageService : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.local_storage']/interface[@name='LocalStorageService']/method[@name='readInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("readInt", "(Ljava/lang/String;I)I", "GetReadInt_Ljava_lang_String_IHandler:Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageServiceInvoker, TruVideoCoreAndroidBinding")]
		int ReadInt (string key, int defaultValue);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.local_storage']/interface[@name='LocalStorageService']/method[@name='readLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("readLong", "(Ljava/lang/String;J)J", "GetReadLong_Ljava_lang_String_JHandler:Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageServiceInvoker, TruVideoCoreAndroidBinding")]
		long ReadLong (string key, long defaultValue);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.local_storage']/interface[@name='LocalStorageService']/method[@name='readString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("readString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "GetReadString_Ljava_lang_String_Ljava_lang_String_Handler:Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageServiceInvoker, TruVideoCoreAndroidBinding")]
		string ReadString (string key, string defaultValue);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.local_storage']/interface[@name='LocalStorageService']/method[@name='storeInt' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("storeInt", "(Ljava/lang/String;I)V", "GetStoreInt_Ljava_lang_String_IHandler:Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageServiceInvoker, TruVideoCoreAndroidBinding")]
		void StoreInt (string key, int value);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.local_storage']/interface[@name='LocalStorageService']/method[@name='storeLong' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='long']]"
		[Register ("storeLong", "(Ljava/lang/String;J)V", "GetStoreLong_Ljava_lang_String_JHandler:Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageServiceInvoker, TruVideoCoreAndroidBinding")]
		void StoreLong (string key, long value);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.service.local_storage']/interface[@name='LocalStorageService']/method[@name='storeString' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("storeString", "(Ljava/lang/String;Ljava/lang/String;)V", "GetStoreString_Ljava_lang_String_Ljava_lang_String_Handler:Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageServiceInvoker, TruVideoCoreAndroidBinding")]
		void StoreString (string key, string value);

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/service/local_storage/LocalStorageService", DoNotGenerateAcw=true)]
	internal partial class ILocalStorageServiceInvoker : global::Java.Lang.Object, ILocalStorageService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/service/local_storage/LocalStorageService", typeof (ILocalStorageServiceInvoker));

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

		public static ILocalStorageService? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILocalStorageService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.service.local_storage.LocalStorageService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILocalStorageServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_readInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetReadInt_Ljava_lang_String_IHandler ()
		{
			if (cb_readInt_Ljava_lang_String_I == null)
				cb_readInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_I (n_ReadInt_Ljava_lang_String_I));
			return cb_readInt_Ljava_lang_String_I;
		}

		static int n_ReadInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_key, int defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadInt (key!, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readInt_Ljava_lang_String_I;
		public unsafe int ReadInt (string key, int defaultValue)
		{
			if (id_readInt_Ljava_lang_String_I == IntPtr.Zero)
				id_readInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "readInt", "(Ljava/lang/String;I)I");
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (defaultValue);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_readInt_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_key);
			return __ret;
		}

		static Delegate? cb_readLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetReadLong_Ljava_lang_String_JHandler ()
		{
			if (cb_readLong_Ljava_lang_String_J == null)
				cb_readLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJ_J (n_ReadLong_Ljava_lang_String_J));
			return cb_readLong_Ljava_lang_String_J;
		}

		static long n_ReadLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_key, long defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.ReadLong (key!, defaultValue);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readLong_Ljava_lang_String_J;
		public unsafe long ReadLong (string key, long defaultValue)
		{
			if (id_readLong_Ljava_lang_String_J == IntPtr.Zero)
				id_readLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "readLong", "(Ljava/lang/String;J)J");
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (defaultValue);
			var __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_readLong_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_key);
			return __ret;
		}

		static Delegate? cb_readString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetReadString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_readString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_readString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_L (n_ReadString_Ljava_lang_String_Ljava_lang_String_));
			return cb_readString_Ljava_lang_String_Ljava_lang_String_;
		}

		static IntPtr n_ReadString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_defaultValue)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var defaultValue = JNIEnv.GetString (native_defaultValue, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.ReadString (key!, defaultValue!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_readString_Ljava_lang_String_Ljava_lang_String_;
		public unsafe string ReadString (string key, string defaultValue)
		{
			if (id_readString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_readString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "readString", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_defaultValue = JNIEnv.NewString ((string?)defaultValue);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (native_defaultValue);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_readString_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef)!;
			JNIEnv.DeleteLocalRef (native_key);
			JNIEnv.DeleteLocalRef (native_defaultValue);
			return __ret;
		}

		static Delegate? cb_storeInt_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetStoreInt_Ljava_lang_String_IHandler ()
		{
			if (cb_storeInt_Ljava_lang_String_I == null)
				cb_storeInt_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLI_V (n_StoreInt_Ljava_lang_String_I));
			return cb_storeInt_Ljava_lang_String_I;
		}

		static void n_StoreInt_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_key, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.StoreInt (key!, value);
		}
#pragma warning restore 0169

		IntPtr id_storeInt_Ljava_lang_String_I;
		public unsafe void StoreInt (string key, int value)
		{
			if (id_storeInt_Ljava_lang_String_I == IntPtr.Zero)
				id_storeInt_Ljava_lang_String_I = JNIEnv.GetMethodID (class_ref, "storeInt", "(Ljava/lang/String;I)V");
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storeInt_Ljava_lang_String_I, __args);
			JNIEnv.DeleteLocalRef (native_key);
		}

		static Delegate? cb_storeLong_Ljava_lang_String_J;
#pragma warning disable 0169
		static Delegate GetStoreLong_Ljava_lang_String_JHandler ()
		{
			if (cb_storeLong_Ljava_lang_String_J == null)
				cb_storeLong_Ljava_lang_String_J = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLJ_V (n_StoreLong_Ljava_lang_String_J));
			return cb_storeLong_Ljava_lang_String_J;
		}

		static void n_StoreLong_Ljava_lang_String_J (IntPtr jnienv, IntPtr native__this, IntPtr native_key, long value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.StoreLong (key!, value);
		}
#pragma warning restore 0169

		IntPtr id_storeLong_Ljava_lang_String_J;
		public unsafe void StoreLong (string key, long value)
		{
			if (id_storeLong_Ljava_lang_String_J == IntPtr.Zero)
				id_storeLong_Ljava_lang_String_J = JNIEnv.GetMethodID (class_ref, "storeLong", "(Ljava/lang/String;J)V");
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storeLong_Ljava_lang_String_J, __args);
			JNIEnv.DeleteLocalRef (native_key);
		}

		static Delegate? cb_storeString_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetStoreString_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_storeString_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_storeString_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLL_V (n_StoreString_Ljava_lang_String_Ljava_lang_String_));
			return cb_storeString_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_StoreString_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Service.Local_storage.ILocalStorageService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.StoreString (key!, value!);
		}
#pragma warning restore 0169

		IntPtr id_storeString_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void StoreString (string key, string value)
		{
			if (id_storeString_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_storeString_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "storeString", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_key = JNIEnv.NewString ((string?)key);
			IntPtr native_value = JNIEnv.NewString ((string?)value);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_key);
			__args [1] = new JValue (native_value);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_storeString_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_key);
			JNIEnv.DeleteLocalRef (native_value);
		}

	}
}
