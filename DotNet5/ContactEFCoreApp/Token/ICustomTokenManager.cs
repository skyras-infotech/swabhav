using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactApp.Domain;

namespace ContactEFCoreApp.Token
{
    public interface ICustomTokenManager
    {
        string CreateToken(User user);
        string CreateTokenForSuperUser(SuperUser user);
        string GetUserInfoByToken(string token);
        bool VerifyToken(string token);
    }
}
