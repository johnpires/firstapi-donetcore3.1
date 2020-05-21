using System;
using System.Collections.Generic;
using System.IdentityModel.Token.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ApiCore_JWTAuthentication.Entities;
using ApiCore_JWTAuthentication.Helpers;

namespace ApiCore_JWTAuthentication
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}