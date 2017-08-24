using System;
using UIKit;
using WebminarCustomRenderers;
using WebminarCustomRenderers.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyEntry),typeof(MyEntryRenderer))]
namespace WebminarCustomRenderers.iOS
{
    public class MyEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);
			var myEntry = Element as MyEntry;
			if (myEntry.ShowBorder)
			{
				Control.Layer.BorderColor = UIColor.Black.CGColor;
				Control.Layer.BorderWidth = 1.0f;
			}
			else
			{
				Control.Layer.BorderColor = UIColor.Clear.CGColor;
				Control.Layer.BorderWidth = 0.0f;
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
					Control.Layer.BorderColor = UIColor.Black.CGColor;
					Control.Layer.BorderWidth = 1.0f;
                }else
                {
					Control.Layer.BorderColor = UIColor.Clear.CGColor;
					Control.Layer.BorderWidth = 0.0f;
                }
            }
        }
    }
}
