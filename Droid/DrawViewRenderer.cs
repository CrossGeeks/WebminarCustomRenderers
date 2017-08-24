using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using WebminarCustomRenderers;
using WebminarCustomRenderers.Droid;

[assembly: ExportRenderer(typeof(DrawView),typeof(DrawViewRenderer))]
namespace WebminarCustomRenderers.Droid
{
    public class DrawViewRenderer : ViewRenderer<DrawView,NativeDrawView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<DrawView> e)
        {
            base.OnElementChanged(e);

            if(Control == null)
            {
                SetNativeControl(new NativeDrawView(Forms.Context));
            }

            if(e.NewElement !=null)
            {
                Control.PaintColor = e.NewElement.DrawColor.ToAndroid();
            }
        }
        
    }
}
