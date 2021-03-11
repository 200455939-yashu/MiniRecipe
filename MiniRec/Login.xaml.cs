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

        private void login(object sender, EventArgs e)
        {
            if (username.Text == "Admin" && password.Text == "admin")
            {
                Debug.WriteLine("Correct username & password");
                App.Current.Properties["loggedIn"] = true;
                minirec.navigationMain("main");
            } else {
                Debug.WriteLine("Wrong username & password");
			}
        }
    }
}
