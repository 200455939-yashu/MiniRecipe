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
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }


    }
}
