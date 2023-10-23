namespace DNAGedcom
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void PageLoaded(object sender, EventArgs e)
        {
            #if WINDOWS
            Windows.UI.Color background = Windows.UI.Color.FromArgb(255,240, 243, 250);
            (blazorWebView.Handler.PlatformView as Microsoft.UI.Xaml.Controls.WebView2).DefaultBackgroundColor = background;
            #endif
        }
    }
}