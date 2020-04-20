using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDApi.Models.Auth
{
    //Entité qui return le token (pour le format JSON correct standard JWT)
    public class AuthenticateToken
    {
        public string Token { get; set; }
    }
}
