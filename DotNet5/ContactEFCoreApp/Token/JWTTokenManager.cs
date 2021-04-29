using ContactApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;
using System.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace ContactEFCoreApp.Token
{
    public class JWTTokenManager : ICustomTokenManager
    {
        private readonly JwtSecurityTokenHandler _tokenHandler;
        private readonly IConfiguration _configuration;
        private readonly byte[] _secretKey;

        public JWTTokenManager(IConfiguration configuration)
        {
            _tokenHandler = new JwtSecurityTokenHandler();
            _configuration = configuration;
            _secretKey = Encoding.ASCII.GetBytes(configuration.GetValue<string>("JwtSecrectKey"));
        }

        public string CreateToken(User user)
        {
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim("id", user.ID.ToString()),
                        new Claim("username", user.Username),
                        new Claim("email", user.Email),
                        new Claim("role", user.Role),
                        new Claim("tenantID", user.TenantID.ToString())
                    }
                ),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(_secretKey),
                    SecurityAlgorithms.HmacSha256Signature
                    )
            };

            var token = _tokenHandler.CreateToken(tokenDescriptor);
            return _tokenHandler.WriteToken(token);
        }

        public string CreateTokenForSuperUser(SuperUser user)
        {
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim("id", user.ID.ToString()),
                        new Claim("username", user.Username),
                    }
                ),
                Expires = DateTime.UtcNow.AddMinutes(30),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(_secretKey),
                    SecurityAlgorithms.HmacSha256Signature
                    )
            };

            var token = _tokenHandler.CreateToken(tokenDescriptor);
            return _tokenHandler.WriteToken(token);
        }

        public string GetUserInfoByToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) return null;
            var jwtToken = _tokenHandler.ReadToken(token.Replace("\"", string.Empty)) as JwtSecurityToken;
            var claim = jwtToken.Claims.FirstOrDefault(x => x.Type == "id");
            if (claim != null) return claim.Value;
            return null;
        }

        public bool VerifyToken(string token)
        {
            if (string.IsNullOrWhiteSpace(token)) return false;
            SecurityToken securityToken;

            try
            {
                _tokenHandler.ValidateToken(
                token.Replace("\"", string.Empty),
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(_secretKey),
                    ValidateLifetime = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ClockSkew = TimeSpan.Zero
                },
                out securityToken);
            }
            catch (SecurityTokenException)
            {
                return false;
            }
            catch (Exception)
            {
                throw;
            }
            return securityToken != null;
        }
    }
}
