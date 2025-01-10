package mono.truvideo.sdk.common.interfaces;


public class AppForegroundListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		truvideo.sdk.common.interfaces.AppForegroundListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onBackground:()V:GetOnBackgroundHandler:Truvideo.Sdk.Common.Interfaces.IAppForegroundListenerInvoker, TruVideoCoreAndroidBinding\n" +
			"n_onForeground:()V:GetOnForegroundHandler:Truvideo.Sdk.Common.Interfaces.IAppForegroundListenerInvoker, TruVideoCoreAndroidBinding\n" +
			"";
		mono.android.Runtime.register ("Truvideo.Sdk.Common.Interfaces.IAppForegroundListenerImplementor, TruVideoCoreAndroidBinding", AppForegroundListenerImplementor.class, __md_methods);
	}


	public AppForegroundListenerImplementor ()
	{
		super ();
		if (getClass () == AppForegroundListenerImplementor.class) {
			mono.android.TypeManager.Activate ("Truvideo.Sdk.Common.Interfaces.IAppForegroundListenerImplementor, TruVideoCoreAndroidBinding", "", this, new java.lang.Object[] {  });
		}
	}


	public void onBackground ()
	{
		n_onBackground ();
	}

	private native void n_onBackground ();


	public void onForeground ()
	{
		n_onForeground ();
	}

	private native void n_onForeground ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
