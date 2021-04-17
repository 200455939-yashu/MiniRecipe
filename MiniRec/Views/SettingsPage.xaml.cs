using System;
using System.Collections.Generic;
using System.Diagnostics;
using MiniRec.ViewModels;
using Xamarin.Forms;

namespace MiniRec.Views {

	public partial class SettingsPage : ContentPage {


		public SettingsPage() {
			BindingContext = new SettingsViewModel();
			InitializeComponent();
		}


	}
}
