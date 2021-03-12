using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace MiniRec.Views {
	public partial class SettingsPage : ContentPage {

		private App minirec = Application.Current as App;

		public SettingsPage() {
			InitializeComponent();
		}

		private async void logout(object sender, EventArgs e) {
			Debug.WriteLine("Logged in: " +
				App.Current.Properties["loggedIn"]);

			if(App.Current.Properties.ContainsKey("loggedIn")) {
				App.Current.Properties["loggedIn"] = false;
			} else {
				App.Current.Properties.Add("loggedIn", false);
			}

			await App.Current.SavePropertiesAsync();
			Debug.WriteLine("Logged in: " +
				App.Current.Properties["loggedIn"]);

			minirec.navigationMain("login");
		}
	}
}
