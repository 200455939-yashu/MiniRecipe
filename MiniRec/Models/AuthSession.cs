using System;
namespace MiniRec.Models
{
    public class AuthSession
    {
        public string token { get; set; }
        public bool error { get; set; }
        public string message { get; set; }
    }
}
