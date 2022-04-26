using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    //İçerisinde şifreleme olan sistemlerde her şeyi byte [] formatında vermemiz gerekiyor.
    //Bunları ASP.NET in jwt servislerinin anlayacağı hale getirmemiz gerek.
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateSecurityKey(string securityKey)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
        }
    }
}
