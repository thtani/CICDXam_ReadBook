using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ReadBooks
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            AppCenterHelper.TrackEvent("login_intent");
            await Navigation.PushModalAsync(new LoginPage());
        }

        private async void AddNewBook_Clicked(object sender, EventArgs e)
        {
            AppCenterHelper.TrackEvent("add_book_intent");
            await Navigation.PushAsync(new NewBookPage());
        }
    }
}
