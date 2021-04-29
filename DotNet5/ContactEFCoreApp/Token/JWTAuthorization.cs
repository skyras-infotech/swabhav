﻿using ContactApp.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

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
            if (context != null) 
            {
                var token = context.HttpContext.Request.Headers["token"].ToString();
                
                if (IsValidToken(token) && _tokenManager.GetUserInfoByToken(token) != null) 
                {
                    return;
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
