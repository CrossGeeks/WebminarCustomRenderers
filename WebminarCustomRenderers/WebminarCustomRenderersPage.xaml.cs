using Xamarin.Forms;

namespace WebminarCustomRenderers
{
    public partial class WebminarCustomRenderersPage : ContentPage
    {
        public WebminarCustomRenderersPage()
        {
            InitializeComponent();
        }

        void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            myEntry.ShowBorder = e.Value;
        }
    }
}
