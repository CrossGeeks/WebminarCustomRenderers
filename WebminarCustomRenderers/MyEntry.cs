using System;
using Xamarin.Forms;

namespace WebminarCustomRenderers
{
    public class MyEntry : Entry
    {
        public bool ShowBorder
        {
            get { return (bool)GetValue(ShowBorderProperty); }
            set { SetValue(ShowBorderProperty,value);}
        }

        public static readonly BindableProperty ShowBorderProperty = BindableProperty.Create(nameof(ShowBorder), typeof(bool), typeof(MyEntry), false);
    }
}
