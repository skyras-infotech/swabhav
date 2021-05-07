using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net;

namespace ContactEFCoreApp.Token
{
    public class JWTAuthorization : Attribute, IAuthorizationFilter
    {
        public string Role { get; set; }
        private ICustomTokenManager _tokenManager;

        public JWTAuthorization() { }

        public JWTAuthorization(string role)
        {
            Role = role;
        }

        public bool IsValidToken(string authToken)
        {
            return _tokenManager.VerifyToken(authToken);
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            _tokenManager = (ICustomTokenManager)context.HttpContext.RequestServices.GetService(typeof(ICustomTokenManager));
            {
                var token = context.HttpContext.Request.Headers["token"].ToString();
                if (_tokenManager != null)
                {
                    var tokenRole = _tokenManager.GetUserInfoByToken(token);
                    if (IsValidToken(token) && tokenRole != null)
                    {
                        if (Role != null)
                        {
                            if (Role == tokenRole)
                            {
                                return;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }

                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new JsonResult("NotAdminRole")
                {
                    Value = new
                    {
                        Status = "Error",
                        Message = "Invalid Role or token"
                    },
                };
            }
        }
    }
}
