using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiniRec.Views {
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TabbedMainPage : TabbedPage {

		private App minirec = Application.Current as App;

		public TabbedMainPage() {
			InitializeComponent();
		}

		private void logout(object sender, EventArgs e) {
			App.Current.Properties["loggedIn"] = false;
			minirec.navigationMain("login");
		}
	}
}
