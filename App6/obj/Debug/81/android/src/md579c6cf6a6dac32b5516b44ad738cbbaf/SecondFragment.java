package md579c6cf6a6dac32b5516b44ad738cbbaf;


public class SecondFragment
	extends android.app.Fragment
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App6.SecondFragment, App6", SecondFragment.class, __md_methods);
	}


	public SecondFragment ()
	{
		super ();
		if (getClass () == SecondFragment.class)
			mono.android.TypeManager.Activate ("App6.SecondFragment, App6", "", this, new java.lang.Object[] {  });
	}

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
