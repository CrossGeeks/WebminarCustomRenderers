using System;
using Xamarin.Forms;

namespace WebminarCustomRenderers
{
    public class DrawView : View
    {
		public Color DrawColor
		{
			get { return (Color)GetValue(DrawColorProperty); }
            set { SetValue(DrawColorProperty, value); }
		}

        public static readonly BindableProperty DrawColorProperty = BindableProperty.Create(nameof(DrawColor), typeof(Color), typeof(DrawView), Color.Black);
    }
}
