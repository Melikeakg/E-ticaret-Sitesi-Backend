using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        // jwt servislerinin o sistemi kullanabilmek için anahtara ihtiyaci var.
        //jwt sisteminin ihtiyaç duyduğu yapılar (sisteme giriş bilgileri gibi)
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            //Kullanılacak anahtar ve şifremizi veriyoruz.
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
        }

    }
}
