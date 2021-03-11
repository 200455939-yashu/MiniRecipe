using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiniRec.ViewModels;

namespace MiniRec.Views {
	public partial class BrowsePage : ContentPage {
		private App minirec = Application.Current as App;

		public BrowsePage() {
			BindingContext = new BrowsePageVM();
			InitializeComponent();
		}

		void collectionList_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e) {
		}


		private void logout(object sender, EventArgs e) {
			App.Current.Properties["loggedIn"] = false;
			minirec.navigationMain("login");
		}
	}
}
