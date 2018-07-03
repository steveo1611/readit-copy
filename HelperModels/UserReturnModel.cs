using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace readit_copy.Models
{
    public class UserReturnModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        internal ClaimsPrincipal SetClaims()
        {
            var claims = new List<Claim> {
                        new Claim(ClaimTypes.Email, Email),
                        new Claim(ClaimTypes.Name, Id.ToString())
                    };
            var userIdentity = new ClaimsIdentity(claims, "login");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            return principal;
        }
    }
}