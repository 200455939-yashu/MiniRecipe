using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MiniRec.ViewModels;

namespace MiniRec
{
    public partial class MainPage : ContentPage
    {
        private App minirec = Application.Current as App;
        public MainPage()
        {
            BindingContext = new MainPageVM();
            InitializeComponent();
        }

        private void logout(object sender, EventArgs e)
        {
            App.Current.Properties["loggedIn"] = false;
            minirec.navigationMain("login");
        }

		void collectionList_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e) {
		}
	}
}
