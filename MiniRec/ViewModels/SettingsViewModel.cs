using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace MiniRec.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        public ICommand LogoutCommand { get; set; }
        public SettingsViewModel()
        {
            Title = "Settings";
            LogoutCommand = new Command(() =>
            {
				Logout();
			});

        }

        private async void Logout()
		{
			Debug.WriteLine("Logged in: " +
				minirec.Properties["loggedIn"]);

			if (minirec.Properties.ContainsKey("loggedIn"))
			{
				minirec.Properties["loggedIn"] = false;
			}
			else
			{
				minirec.Properties.Add("loggedIn", false);
			}

            await minirec.SavePropertiesAsync();
			Debug.WriteLine("Logged in: " +
				minirec.Properties["loggedIn"]);

			minirec.NavigateMain(MainNavOption.WelcomePage);
		}
	}
}
