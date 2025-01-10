using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Truvideo.Sdk.Common.Interfaces {

	// Metadata.xml XPath interface reference: path="/api/package[@name='truvideo.sdk.common.interfaces']/interface[@name='AppForegroundListener']"
	[Register ("truvideo/sdk/common/interfaces/AppForegroundListener", "", "Truvideo.Sdk.Common.Interfaces.IAppForegroundListenerInvoker")]
	public partial interface IAppForegroundListener : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.interfaces']/interface[@name='AppForegroundListener']/method[@name='onBackground' and count(parameter)=0]"
		[Register ("onBackground", "()V", "GetOnBackgroundHandler:Truvideo.Sdk.Common.Interfaces.IAppForegroundListenerInvoker, TruVideoCoreAndroidBinding")]
		void OnBackground ();

		// Metadata.xml XPath method reference: path="/api/package[@name='truvideo.sdk.common.interfaces']/interface[@name='AppForegroundListener']/method[@name='onForeground' and count(parameter)=0]"
		[Register ("onForeground", "()V", "GetOnForegroundHandler:Truvideo.Sdk.Common.Interfaces.IAppForegroundListenerInvoker, TruVideoCoreAndroidBinding")]
		void OnForeground ();

	}

	[global::Android.Runtime.Register ("truvideo/sdk/common/interfaces/AppForegroundListener", DoNotGenerateAcw=true)]
	internal partial class IAppForegroundListenerInvoker : global::Java.Lang.Object, IAppForegroundListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("truvideo/sdk/common/interfaces/AppForegroundListener", typeof (IAppForegroundListenerInvoker));

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

		public static IAppForegroundListener? GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAppForegroundListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'truvideo.sdk.common.interfaces.AppForegroundListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAppForegroundListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate? cb_onBackground;
#pragma warning disable 0169
		static Delegate GetOnBackgroundHandler ()
		{
			if (cb_onBackground == null)
				cb_onBackground = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnBackground));
			return cb_onBackground;
		}

		static void n_OnBackground (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Interfaces.IAppForegroundListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnBackground ();
		}
#pragma warning restore 0169

		IntPtr id_onBackground;
		public unsafe void OnBackground ()
		{
			if (id_onBackground == IntPtr.Zero)
				id_onBackground = JNIEnv.GetMethodID (class_ref, "onBackground", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onBackground);
		}

		static Delegate? cb_onForeground;
#pragma warning disable 0169
		static Delegate GetOnForegroundHandler ()
		{
			if (cb_onForeground == null)
				cb_onForeground = JNINativeWrapper.CreateDelegate (new _JniMarshal_PP_V (n_OnForeground));
			return cb_onForeground;
		}

		static void n_OnForeground (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Truvideo.Sdk.Common.Interfaces.IAppForegroundListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnForeground ();
		}
#pragma warning restore 0169

		IntPtr id_onForeground;
		public unsafe void OnForeground ()
		{
			if (id_onForeground == IntPtr.Zero)
				id_onForeground = JNIEnv.GetMethodID (class_ref, "onForeground", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onForeground);
		}

	}

	[global::Android.Runtime.Register ("mono/truvideo/sdk/common/interfaces/AppForegroundListenerImplementor")]
	internal sealed partial class IAppForegroundListenerImplementor : global::Java.Lang.Object, IAppForegroundListener {

		object? sender;

		public unsafe IAppForegroundListenerImplementor (object sender) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;
			var h = JniPeerMembers.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
			SetHandle (h.Handle, JniHandleOwnership.TransferLocalRef);
			JniPeerMembers.InstanceMethods.FinishCreateInstance (__id, this, null);
			this.sender = sender;
		}

		#pragma warning disable 0649
		public EventHandler? OnBackgroundHandler;
		#pragma warning restore 0649

		public void OnBackground ()
		{
			var __h = OnBackgroundHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		#pragma warning disable 0649
		public EventHandler? OnForegroundHandler;
		#pragma warning restore 0649

		public void OnForeground ()
		{
			var __h = OnForegroundHandler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IAppForegroundListenerImplementor value)
		{
			return value.OnBackgroundHandler == null && value.OnForegroundHandler == null;
		}

	}
}
