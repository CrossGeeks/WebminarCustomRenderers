using System;
using WebminarCustomRenderers;
using WebminarCustomRenderers.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(DrawView), typeof(DrawViewRenderer))]
namespace WebminarCustomRenderers.iOS
{
    public class DrawViewRenderer : ViewRenderer<DrawView, NativeDrawView>
    {
		protected override void OnElementChanged(ElementChangedEventArgs<DrawView> e)
		{
			base.OnElementChanged(e);

			if (Control == null)
			{
				SetNativeControl(new NativeDrawView());
			}

			if (e.NewElement != null)
			{
				Control.PaintColor = e.NewElement.DrawColor.ToUIColor();
			}
		}
    }
}
