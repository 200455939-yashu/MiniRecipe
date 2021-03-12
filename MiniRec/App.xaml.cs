using System;
using System.Diagnostics;
using MiniRec.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniRec
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
        }

        public void navigationMain(string to)
        {
            switch (to)
            {
                case "login":
                    MainPage = new NavigationPage(new Login());
                    break;
                case "main":
                    MainPage = new TabbedMainPage();
                    break;
            }
        }

        protected override void OnStart()
        {
            if(App.Current.Properties.ContainsKey("loggedIn")) {
                Debug.WriteLine("Logged in on start: " + App.Current.Properties["loggedIn"]);
			} else {
                Debug.WriteLine("Logged in key does not exist on start");
            }

            var isLoggedIn =
                App.Current.Properties.ContainsKey("loggedIn") ?
                (bool)App.Current.Properties["loggedIn"] : false;

            if (!isLoggedIn)
            {
                MainPage = new NavigationPage(new Login());
            }
            else
            {
                MainPage = new TabbedMainPage();
            }
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            if(App.Current.Properties.ContainsKey("loggedIn")) {
                Debug.WriteLine("Logged in on resume: " + App.Current.Properties["loggedIn"]);
            } else {
                Debug.WriteLine("Logged in key does not exist on resume");
            }

            var isLoggedIn =
                App.Current.Properties.ContainsKey("loggedIn") ?
                (bool)App.Current.Properties["loggedIn"] : false;

            if(!isLoggedIn) {
                MainPage = new NavigationPage(new Login());
            } else {
                MainPage = new TabbedMainPage();
            }
        }
    }
}
