package crc64a46247c650913d16;


public class Glyphs
	extends crc64a352b6f848b4d68e.FrameworkElement
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Microsoft.UI.Xaml.Documents.Glyphs, Uno.UI", Glyphs.class, __md_methods);
	}


	public Glyphs (android.content.Context p0)
	{
		super (p0);
		if (getClass () == Glyphs.class)
			mono.android.TypeManager.Activate ("Microsoft.UI.Xaml.Documents.Glyphs, Uno.UI", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
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
