using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Adapter.Http {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.adapter.http']/interface[@name='HttpAdapter']"
	[Register ("truvideo/sdk/common/adapter/http/HttpAdapter", "", "Truvideo.Sdk.Common.Adapter.Http.IHttpAdapterInvoker")]
	public partial interface IHttpAdapter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.adapter.http']/interface[@name='HttpAdapter']/method[@name='get' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='boolean'] and parameter[4][@type='boolean'] and parameter[5][@type='kotlin.coroutines.Continuation&lt;? super truvideo.sdk.common.model.TruvideoSdkHttpResponse&gt;']]"
		[Register ("get", "(Ljava/lang/String;Ljava/util/Map;ZZLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetGet_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Adapter.Http.IHttpAdapterInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Get (string url, global::System.Collections.Generic.IDictionary<string, string> headers, bool retry, bool addLogs, global::Kotlin.Coroutines.IContinuation p4);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.adapter.http']/interface[@name='HttpAdapter']/method[@name='head' and count(parameter)=4 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean'] and parameter[4][@type='kotlin.coroutines.Continuation&lt;? super truvideo.sdk.common.model.TruvideoSdkHttpResponse&gt;']]"
		[Register ("head", "(Ljava/lang/String;ZZLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetHead_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Adapter.Http.IHttpAdapterInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Head (string url, bool retry, bool addLogs, global::Kotlin.Coroutines.IContinuation p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.adapter.http']/interface[@name='HttpAdapter']/method[@name='post' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.String&gt;'] and parameter[3][@type='java.lang.Object'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean'] and parameter[6][@type='kotlin.coroutines.Continuation&lt;? super truvideo.sdk.common.model.TruvideoSdkHttpResponse&gt;']]"
		[Register ("post", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;ZZLkotlin/coroutines/Continuation;)Ljava/lang/Object;", "GetPost_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_Handler:Truvideo.Sdk.Common.Adapter.Http.IHttpAdapterInvoker, TruVideoCoreAndroidBinding")]
		global::Java.Lang.Object? Post (string url, global::System.Collections.Generic.IDictionary<string, string> headers, global::Java.Lang.Object? body, bool retry, bool addLogs, global::Kotlin.Coroutines.IContinuation p5);

		// Metadata.xml XPath class reference: path="/api/package[@name='truvideo.sdk.common.adapter.http']/class[@name='HttpAdapter.DefaultImpls']"
		[global::Android.Runtime.Register ("truvideo/sdk/common/adapter/http/HttpAdapter$DefaultImpls", DoNotGenerateAcw=true)]
		public sealed partial class DefaultImpls : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/adapter/http/HttpAdapter$DefaultImpls", typeof (DefaultImpls));

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

	[global::Android.Runtime.Register ("truvideo/sdk/common/adapter/http/HttpAdapter", DoNotGenerateAcw=true)]
	internal partial class IHttpAdapterInvoker : global::Java.Lang.Object, IHttpAdapter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/adapter/http/HttpAdapter", typeof (IHttpAdapterInvoker));

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

		public static IHttpAdapter? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHttpAdapter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.adapter.http.HttpAdapter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHttpAdapterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetGet_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_ == null)
				cb_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLZZL_L (n_Get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_));
			return cb_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, bool retry, bool addLogs, IntPtr native_p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Adapter.Http.IHttpAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			var p4 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p4, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Get (url!, headers!, retry, addLogs, p4!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Get (string url, global::System.Collections.Generic.IDictionary<string, string> headers, bool retry, bool addLogs, global::Kotlin.Coroutines.IContinuation p4)
		{
			if (id_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "get", "(Ljava/lang/String;Ljava/util/Map;ZZLkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_url = JNIEnv.NewString ((string?)url);
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (native_url);
			__args [1] = new JValue (native_headers);
			__args [2] = new JValue (retry);
			__args [3] = new JValue (addLogs);
			__args [4] = new JValue ((p4 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p4).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_get_Ljava_lang_String_Ljava_util_Map_ZZLkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_url);
			JNIEnv.DeleteLocalRef (native_headers);
			return __ret;
		}

		static Delegate? cb_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetHead_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_ == null)
				cb_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLZZL_L (n_Head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_));
			return cb_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, bool retry, bool addLogs, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Adapter.Http.IHttpAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var p3 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Head (url!, retry, addLogs, p3!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Head (string url, bool retry, bool addLogs, global::Kotlin.Coroutines.IContinuation p3)
		{
			if (id_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "head", "(Ljava/lang/String;ZZLkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_url = JNIEnv.NewString ((string?)url);
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (native_url);
			__args [1] = new JValue (retry);
			__args [2] = new JValue (addLogs);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_head_Ljava_lang_String_ZZLkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_url);
			return __ret;
		}

		static Delegate? cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_;
#pragma warning disable 0169
		static Delegate GetPost_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_Handler ()
		{
			if (cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_ == null)
				cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_ = JNINativeWrapper.CreateDelegate (new _JniMarshal_PPLLLZZL_L (n_Post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_));
			return cb_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_;
		}

		static IntPtr n_Post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url, IntPtr native_headers, IntPtr native_body, bool retry, bool addLogs, IntPtr native_p5)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Adapter.Http.IHttpAdapter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			var headers = global::Android.Runtime.JavaDictionary<string, string>.FromJniHandle (native_headers, JniHandleOwnership.DoNotTransfer);
			var body = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_body, JniHandleOwnership.DoNotTransfer);
			var p5 = (global::Kotlin.Coroutines.IContinuation?)global::Java.Lang.Object.GetObject<global::Kotlin.Coroutines.IContinuation> (native_p5, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Post (url!, headers!, body, retry, addLogs, p5!));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_;
		public unsafe global::Java.Lang.Object? Post (string url, global::System.Collections.Generic.IDictionary<string, string> headers, global::Java.Lang.Object? body, bool retry, bool addLogs, global::Kotlin.Coroutines.IContinuation p5)
		{
			if (id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_ == IntPtr.Zero)
				id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_ = JNIEnv.GetMethodID (class_ref, "post", "(Ljava/lang/String;Ljava/util/Map;Ljava/lang/Object;ZZLkotlin/coroutines/Continuation;)Ljava/lang/Object;");
			IntPtr native_url = JNIEnv.NewString ((string?)url);
			IntPtr native_headers = global::Android.Runtime.JavaDictionary<string, string>.ToLocalJniHandle (headers);
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue (native_url);
			__args [1] = new JValue (native_headers);
			__args [2] = new JValue ((body == null) ? IntPtr.Zero : ((global::Java.Lang.Object) body).Handle);
			__args [3] = new JValue (retry);
			__args [4] = new JValue (addLogs);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_post_Ljava_lang_String_Ljava_util_Map_Ljava_lang_Object_ZZLkotlin_coroutines_Continuation_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_url);
			JNIEnv.DeleteLocalRef (native_headers);
			return __ret;
		}

	}
}
