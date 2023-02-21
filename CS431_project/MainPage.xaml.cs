using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CS431_project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Celsius_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(celsius_fahrenheit));

        }

        private void Miles_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MilesKilometers));

        }

        private void Pounds_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(pounds_kilograms));

        }

        private void Liters_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(LitersGallons));

        }


    }
}
