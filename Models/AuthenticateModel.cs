using System.ComponentModel.DataAnnotations;

namespace ApiCore_JWTAuthentication.Models
{
    public class AutenticateModel
    {
        public string UserName {get; set;}
        public string Password {get; set;}

    }
}