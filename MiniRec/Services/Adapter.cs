using System;
using MiniRec.Services.Auth;
using MiniRec.Shared;

namespace MiniRec.Services
{
    public class Adapter
    {
        public Adapter()
        {
        }

        public IAuthService authService
        {
            get
            {
                switch (Settings.Shared.authType)
                {
                    //case AuthType.Aws:
                    //    return new AwsAuthService();
                    case AuthType.Mock:
                        return new FakeAuthService();
                }

                return new FakeAuthService();

            }

        }

        public static Adapter Shared = new Adapter();
    }
}

