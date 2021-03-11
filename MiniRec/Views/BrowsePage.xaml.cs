using System;
using System.Collections.Generic;

using Xamarin.Forms;
using MiniRec.ViewModels;
using System.Diagnostics;
using System.Linq;
using MiniRec.Models;

namespace MiniRec.Views {
	public partial class BrowsePage : ContentPage {
		private App minirec = Application.Current as App;

		public BrowsePage() {
			BindingContext = new BrowsePageVM();
			InitializeComponent();
		}

		void collectionList_SelectionChanged(System.Object sender, Xamarin.Forms.SelectionChangedEventArgs e) {
			if(collectionList.SelectedItem == null) return;

			var categoryObject = (e.CurrentSelection.FirstOrDefault() as Category);

			if(categoryObject != null) {

				string current = categoryObject.Name;

				Debug.WriteLine($"current selected category:{current}");
			}

			//collectionList.SelectedItem = null;
		}


		private void logout(object sender, EventArgs e) {
			App.Current.Properties["loggedIn"] = false;
			minirec.navigationMain("login");
		}
	}
}
