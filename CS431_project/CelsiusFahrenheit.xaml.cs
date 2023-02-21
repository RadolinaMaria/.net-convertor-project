using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CS431_project
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class celsius_fahrenheit : Page
    {
        public celsius_fahrenheit()
        {
            this.InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));

        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            //numbers.Add(1);
            //numbers.Add(1);
            //double formula = 33.8;
            int celsius = int.Parse(celsiusValue.Text);

            double fahrenheit = celsius * 1.8 + 32;
            fahrenheitValue.Text = fahrenheit.ToString("N2");

        }
    }
}
