using OptionalPackageWithPageToShow;
using System;
using System.Linq;
using Windows.ApplicationModel;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MainApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(HelloPage));
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var optionalPackage = Package.Current.Dependencies.FirstOrDefault(p => p.IsOptional);
            if (optionalPackage is object && optionalPackage.Id.Name == "ad4d8e16-9f9c-458f-ac0f-e74cb99fa10c" && optionalPackage.Status.VerifyIsOK())
            {
                ContentFrame.Navigate(typeof(HalloPage));
            }
            else
            {
                var dialog = new MessageDialog("Optional package is not installed.", "Can't show page");
                await dialog.ShowAsync();
            }
        }
    }
}
