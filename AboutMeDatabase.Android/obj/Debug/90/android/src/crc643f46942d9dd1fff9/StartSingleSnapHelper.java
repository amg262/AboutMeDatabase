package crc643f46942d9dd1fff9;


public class StartSingleSnapHelper
	extends crc643f46942d9dd1fff9.SingleSnapHelper
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_calculateDistanceToFinalSnap:(Landroid/support/v7/widget/RecyclerView$LayoutManager;Landroid/view/View;)[I:GetCalculateDistanceToFinalSnap_Landroid_support_v7_widget_RecyclerView_LayoutManager_Landroid_view_View_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.StartSingleSnapHelper, Xamarin.Forms.Platform.Android", StartSingleSnapHelper.class, __md_methods);
	}


	public StartSingleSnapHelper ()
	{
		super ();
		if (getClass () == StartSingleSnapHelper.class) {
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.StartSingleSnapHelper, Xamarin.Forms.Platform.Android", "", this, new java.lang.Object[] {  });
		}
	}


	public int[] calculateDistanceToFinalSnap (android.support.v7.widget.RecyclerView.LayoutManager p0, android.view.View p1)
	{
		return n_calculateDistanceToFinalSnap (p0, p1);
	}

	private native int[] n_calculateDistanceToFinalSnap (android.support.v7.widget.RecyclerView.LayoutManager p0, android.view.View p1);

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
