using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MiniRec
{
    public class Nav
    {
        private App displayApp = Application.Current as App;
        public Nav()
        {
        }
       public Task DisplayAlertAsync(String title, String message, String button = "OK") {
            return displayApp.MainPage.DisplayAlert(title, message, "OK");
        }
        public static Nav Shared = new Nav();
    }
}
