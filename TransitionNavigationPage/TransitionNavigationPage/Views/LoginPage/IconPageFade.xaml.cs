using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TransitionNavigationPage.Views.LoginPage
{
    // Base view for MVVM in XLabs
    public partial class IconPageFade : ContentPage
    {
        public IconPageFade()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);

            // Waiting some time
            await Task.Delay(2000);

            // Start animation
            await Task.WhenAll(
                SplashGrid.FadeTo(0, 2000),
                Logo.ScaleTo(10, 2000)
                );

            await Navigation.PushAsync(new LoginPage());
        }
    }
}
