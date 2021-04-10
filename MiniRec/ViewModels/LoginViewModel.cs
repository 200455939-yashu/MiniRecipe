using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiniRec.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public string _Username;
        public string Username {
            get {return _Username;}
            set { SetProperty(ref _Username, value);  }
        }
        public string _Password;
        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }

        //Private methods
        private App minirec = Application.Current as App;
        public Command LoginCommand { get; set; }
        public LoginViewModel()
        {
            Title = "Login Screen";
            LoginCommand = new Command(() =>
            {
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                Task task = login();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            });
        }

        private async Task login()
        {
            if (Username == "Admin" && Password == "admin")
            {
                Debug.WriteLine("Correct username & password");

                if (minirec.Properties.ContainsKey("loggedIn"))
                {
                    minirec.Properties["loggedIn"] = true;
                }
                else
                {
                    minirec.Properties.Add("loggedIn", true);
                }

                await minirec.SavePropertiesAsync();
                minirec.navigationMain("main");
            }
            else
            {

                await minirec.MainPage.DisplayAlert("Alert", "Invalid Username or Password", "OK");
                Username = "";
                Password = "";
            }
        }
    }
}
