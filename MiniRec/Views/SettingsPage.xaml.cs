using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace MiniRec.Views {
	public partial class SettingsPage : ContentPage {

		private App minirec = Application.Current as App;

		public SettingsPage() {
			InitializeComponent();

			Debug.WriteLine("Logged in: " +
				App.Current.Properties["loggedIn"]);
		}

		private void logout(object sender, EventArgs e) {
			Debug.WriteLine("Logged in: " +
				App.Current.Properties["loggedIn"]);
			App.Current.Properties["loggedIn"] = false;

			Debug.WriteLine("Logged in: " +
				App.Current.Properties["loggedIn"]);

			minirec.navigationMain("login");
		}
	}
}
