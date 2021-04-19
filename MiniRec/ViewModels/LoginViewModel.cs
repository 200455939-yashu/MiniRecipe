using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MiniRec.Models;
using MiniRec.Services;
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

            if (Username == null || Password == null)
            {
                await minirec.MainPage.DisplayAlert("Error", "Please enter username/password", "Ok");
                return;
            }



            Debug.WriteLine("Auth process started ..");

            try
            {
                var service = Adapter.Shared.authService;
                var resultObject = await service.SignInAsync(Username, Password);

                if (resultObject != null)
                {
                    //Error true
                    if (resultObject.error)
                    {
                        if (resultObject.message == "PassMismatch")
                        {
                            await minirec.MainPage.DisplayAlert("Alert","Invalid password", "ok");
                        }
                        else if (resultObject.message == "UserNotFound")
                        {
                            await minirec.MainPage.DisplayAlert("Alert","Account not found!", "ok");
                        }
                        else
                        {
                            await minirec.MainPage.DisplayAlert("Alert","Unknown error!", "ok");
                        }
                    }

                    //No Error
                    else
                    {
                        if (resultObject.token != null)
                        {
                            await minirec.MainPage.DisplayAlert("Alert","Success login", "OK");
                            //TODO: save token in app properties
                            await minirec.SavePropertyAsync(KEYS.KEY_USERNAME, Username);
                            await minirec.SavePropertyAsync(KEYS.KEY_USERTOKEN, Password);
                            await minirec.SavePropertyAsync("token", resultObject.token);
                            minirec.SignIn();
                        }
                        else
                        {
                            await minirec.MainPage.DisplayAlert("Alert","Token not found!", "Ok");
                        }
                    }
                }
                else
                {
                    await minirec.MainPage.DisplayAlert("Alert","Unknown Error", "OK");
                }



            }
            catch (Exception e)
            {
                await minirec.MainPage.DisplayAlert("Alert",$"Something went wrong:{e.Message}", "OK");
                throw new Exception($"Something went wrong:{e.Message}");
            }




            //if (Username == "Admin" && Password == "admin")
            //{
            //    Debug.WriteLine("Correct username & password");

            //    if (minirec.Properties.ContainsKey("loggedIn"))
            //    {
            //        minirec.Properties["loggedIn"] = true;
            //    }
            //    else
            //    {
            //        minirec.Properties.Add("loggedIn", true);
            //    }

            //    await minirec.SavePropertiesAsync();
            //    minirec.navigationMain("main");
            //}
            //else
            //{
            //    await Nav.Shared.DisplayAlertAsync("Alert", "Invalid Username or Password");
            //    //await minirec.MainPage.DisplayAlert("Alert", "Invalid Username or Password", "OK");
            //    Username = "";
            //    Password = "";
            //}
        }
    }
}
