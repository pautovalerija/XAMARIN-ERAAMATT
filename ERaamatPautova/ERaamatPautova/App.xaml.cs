using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ERaamatPautova
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ERaamatPautova.MainPage())
            {
                BarBackgroundColor = Color.FromHex("#785e4d")
            };
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
