﻿using System;
using System.Collections.Generic;

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
            if (username.Text == "yashu" && password.Text == "yashu")
            {
                App.Current.Properties["loggedIn"] = true;
                minirec.navigationMain("main");
            }
        }
    }
}
