using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ReadBooks
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                // TODO: adding login
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
                {
                    { "user", "tester@app.com" },
                    { "network", "WiFi" }
                };
                AppCenterHelper.TrackEvent("logged_in", keyValuePairs);
                await Navigation.PopModalAsync(true);
            }
            catch (Exception ex)
            {
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
                {
                    { "Signal", "Strong" },
                    { "NewUser", "False" },
                    { "WiFi", "On" }
                };
                AppCenterHelper.TrackError(ex, keyValuePairs);
            }   
        }
    }
}