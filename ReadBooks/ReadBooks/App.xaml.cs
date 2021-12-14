using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadBooks
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
        {
            AppCenter.Start("ios=ae24a137-515a-412b-b3b7-41793005f4c3;" + 
                            "android=35d0caeb-8819-4203-8afc-ada6a0dce4b7", 
                            typeof(Analytics), typeof(Crashes));

            bool didAppCrash = await Crashes.HasCrashedInLastSessionAsync();
            if (didAppCrash)
            {
                await MainPage.DisplayAlert("I'm sorry", "It appears we had some issue there, sorry about that.", "Don't worry");
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
