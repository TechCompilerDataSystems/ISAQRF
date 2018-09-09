using TransitionNavigationPage.Views.LoginPage;
using Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UIKit;

namespace TransitionNavigationPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new Views.LoginPage.SupportFiles.TransitionNavigationPage(new IconPageFade()) 
            { 
                BarTextColor = Xamarin.Forms.Color.White,
                BarBackgroundColor=Xamarin.Forms.Color.FromRgb(141,72,58)
            };
            //MainPage = new Controls.TransitionNavigationPage(new MainView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
