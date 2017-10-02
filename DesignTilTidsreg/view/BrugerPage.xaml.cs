using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace DesignTilTidsreg.view
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BrugerPage : Page
    {
        public BrugerPage()
        {
            this.InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(OverarbejdePage));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Login));
        }

        private async void CheckInd(object sender, RoutedEventArgs e)
        {
            TjekUd.IsEnabled = true;
            TjekInd.IsEnabled = false;


            var dialog = new MessageDialog("Du er nu Checket Ind");
            await dialog.ShowAsync();
        }


        private async void CheckUd(object sender, RoutedEventArgs e)
        {
            TjekUd.IsEnabled = false;
            TjekInd.IsEnabled = true;


            var dialog = new MessageDialog("Du er nu Checket Ud");
            await dialog.ShowAsync();
        }





    }
}
