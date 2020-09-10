using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace OptionalPackageWithPageToShow
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HalloPage : Page
    {
        public HalloPage()
        {
            // DON'T call InitializeComponent

            // ad4d8e16-9f9c-458f-ac0f-e74cb99fa10c is the optional package's identity name
            Uri resourceLocator = new Uri("ms-appx://ad4d8e16-9f9c-458f-ac0f-e74cb99fa10c/HalloPage.xaml");

            Application.LoadComponent(this, resourceLocator, ComponentResourceLocation.Nested);
        }
    }
}
