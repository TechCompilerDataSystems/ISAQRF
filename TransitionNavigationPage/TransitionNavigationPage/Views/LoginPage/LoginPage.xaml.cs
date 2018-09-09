using System;
using TransitionNavigationPage.Views.LoginPage.LoginDetailPage;
using TransitionNavigationPage.Views.LoginPage.SupportFiles;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TransitionNavigationPage.Views.LoginPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public static bool allowClick = false;
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<MainViewModel, TransitionType>(this, AppSettings.ScanQRCode, (sender, arg) =>
            {
                if (allowClick)
                {
                    var transitionType = (TransitionType)arg;
                    var transitionNavigationPage = Parent as SupportFiles.TransitionNavigationPage;

                    if (transitionNavigationPage != null)
                    {
                        transitionNavigationPage.TransitionType = transitionType;
                        Navigation.PushAsync(new ScanQRCodePage());
                    }
                    allowClick = false;
                }

            });

            MessagingCenter.Subscribe<MainViewModel, TransitionType>(this, AppSettings.LoginByQRCode, (sender, arg) =>
            {
                if (allowClick)
                {
                    var transitionType = (TransitionType)arg;
                    var transitionNavigationPage = Parent as SupportFiles.TransitionNavigationPage;

                    if (transitionNavigationPage != null)
                    {
                        transitionNavigationPage.TransitionType = transitionType;
                        Navigation.PushAsync(new LoginByQRCodePage());
                    }
                    allowClick = false;
                }
            });

            MessagingCenter.Subscribe<MainViewModel, TransitionType>(this, AppSettings.LoginByPassword, (sender, arg) =>
            {
                if (allowClick)
                {
                    var transitionType = (TransitionType)arg; 
                    var transitionNavigationPage = Parent as SupportFiles.TransitionNavigationPage;

                    if (transitionNavigationPage != null)
                    {
                        transitionNavigationPage.TransitionType = transitionType;
                        Navigation.PushAsync(new LoginByPasswordPage());
                    }
                    allowClick = false;
                }
            });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<MainViewModel, TransitionType>(this, AppSettings.TransitionMessage);
        }
    }
}
