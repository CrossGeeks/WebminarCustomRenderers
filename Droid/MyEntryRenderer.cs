using System;
using Android.Support.V4.Content;
using WebminarCustomRenderers;
using WebminarCustomRenderers.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
namespace WebminarCustomRenderers.Droid
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if(e.NewElement !=null)
            {
				var myEntry = Element as MyEntry;
				if (myEntry.ShowBorder)
				{
					Control.SetBackground(ContextCompat.GetDrawable(Forms.Context, Resource.Drawable.border));
				}
				else
				{
					Control.SetBackground(null);
				}
            }
			
        }

        protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if(e.PropertyName == MyEntry.ShowBorderProperty.PropertyName)
            {
                var myEntry = Element as MyEntry;
                if(myEntry.ShowBorder)
                {
					Control.SetBackground(ContextCompat.GetDrawable(Forms.Context, Resource.Drawable.border));
                }else
                {
					Control.SetBackground(null);
                }
            }
        }
    }
}
