using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TDApi.Models.Auth;

namespace TDApi.Services
{ 
    // le contrat de service
    public interface IUserService
    {
        AuthenticateToken Authenticate(string username, string password);
    }
}
