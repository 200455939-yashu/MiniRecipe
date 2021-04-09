using System;
using System.Collections.Generic;
using System.Diagnostics;
using MiniRec.ViewModels;
using Xamarin.Forms;

namespace MiniRec
{
    public partial class Login : ContentPage
    {
        private App minirec = Application.Current as App;
        public Login()
        {
            BindingContext = new LoginViewModel();
            InitializeComponent();
        }

        private async void login(object sender, EventArgs e)
        {
            if (username.Text == "Admin" && password.Text == "admin")
            {
                Debug.WriteLine("Correct username & password");

                if (App.Current.Properties.ContainsKey("loggedIn"))
                {
                    App.Current.Properties["loggedIn"] = true;
                }
                else
                {
                    App.Current.Properties.Add("loggedIn", true);
                }

                await App.Current.SavePropertiesAsync();
                minirec.navigationMain("main");
            }
            else { 

                await DisplayAlert("Alert", "Invalid Username or Password", "OK");
                username.Text = "";
                password.Text = "";
            }
        }
    }
}
