using Xamarin.Forms;
namespace XF_443_1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Ok.Clicked += (s, e) => Show.Text = Name.Text;
            Clear.Clicked += (s, e) =>
            {
                Name.Text = string.Empty;
                Show.Text = "Show";
            };
        }
    }
}
