using System;
using System.Threading.Tasks;
using MiniRec.Models;

namespace MiniRec.Services.Auth
{
    public interface IAuthService
    {        
        Task<AuthSession> SignInAsync(string username, string password);
    }
}
