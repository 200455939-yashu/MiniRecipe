using System;
namespace MiniRec.Shared
{
    public enum AuthType
    {
        Aws,
        Mock
    }
    public class Settings
    {
        public static string mockUserPassword = "admin";
        public static string mockUsername = "Admin";
        public static string mockToken = "fdsakljdioklsd;dlskjsek";

        public AuthType authType = AuthType.Aws;

        public string API_Test = "testing ";
        public string API_AWS_AuthSignin {
            get => Constants.API_AWS_Base + "/dev/auth";
        }

        public Settings()
        {
        }

        public static Settings Shared = new Settings();
    }
}
