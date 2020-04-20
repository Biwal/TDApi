using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using TDApi.Models;
using TDApi.Models.Auth;

namespace TDApi.Services
{
    public class UserService : IUserService
    {
        //pour accéder à la clé secret des AppSettings
        private readonly Helpers.AppSettings _appSettings;
        public UserService(IOptions<Helpers.AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        AuthenticateToken IUserService.Authenticate(string username, string password)
        {
            //chiffre le password pour la requete
            string hashpwd = GenerateHashPwd(password);

            using (FilmsContext context = new FilmsContext())
            {
                //recherche le user dans la base
                User user = context.Users.SingleOrDefault(x => x.Username == username && x.Password == hashpwd);

                // return null si le user n'est pas trouvé
                if (user == null) return null;

                // authentification ok donc génération du token 
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                byte[] key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[] {
                        new Claim(ClaimTypes.Name, user.Id.ToString())
                    }),
                    Expires = DateTime.UtcNow.AddDays(7),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
                return new AuthenticateToken { Token = tokenHandler.WriteToken(token) };
               /* return new AuthenticateToken { Token = token.ToString() };*/

            }
        }

     

        //génération du hash du pwd
        private string GenerateHashPwd(string password)
        {
            byte[] salt = Encoding.ASCII.GetBytes(_appSettings.Secret);
            string pwdhashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                    password: password,
                    salt: salt,
                    prf: KeyDerivationPrf.HMACSHA256,
                    iterationCount: 10000,
                    numBytesRequested: 256 / 8));
            return pwdhashed;
        }
    }
}
