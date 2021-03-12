using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace MiniRec
{
    public partial class Login : ContentPage
    {
        private App minirec = Application.Current as App;
        public Login()
        {
            InitializeComponent();
        }

        private async void login(object sender, EventArgs e)
        {
            if (username.Text == "Admin" && password.Text == "admin")
            {
                Debug.WriteLine("Correct username & password");

                if(App.Current.Properties.ContainsKey("loggedIn")) {
                    App.Current.Properties["loggedIn"] = true;
                } else {
                    App.Current.Properties.Add("loggedIn", true);
                }

                await App.Current.SavePropertiesAsync();
                minirec.navigationMain("main");
            } else {
                Debug.WriteLine("Wrong username & password");
			}
        }
    }
}
