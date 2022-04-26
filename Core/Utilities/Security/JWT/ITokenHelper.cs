using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    //Login olurken mesela email ve parola doğruysa bu opreasyon çalışır.
    //İlgili kullanıcı için veritabanına gidecek ve o kullanıcının claimlerini bulacak//
    // O kullanıcı için JWT üretecek 
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        
    }
}
