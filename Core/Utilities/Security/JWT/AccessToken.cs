using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Token ve tokenin bitiş süresi
    //Mesela postman da bir istek yapıldığında ona bir token ve o tokenin bitiş süresini vereceğiz 
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }

    }
}
