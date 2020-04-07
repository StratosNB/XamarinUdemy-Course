using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUdemy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new XamarinUdemy.HomePage());
            MainPage.Title = "Cinemo";
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
