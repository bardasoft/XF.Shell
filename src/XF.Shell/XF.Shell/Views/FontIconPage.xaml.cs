using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Shell.ViewModels;

namespace XF.Shell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FontIconPage : ContentPage
    {
        public FontIconPage()
        {
            InitializeComponent();

            BindingContext = new FontIconPageViewModel();
        }
    }
}