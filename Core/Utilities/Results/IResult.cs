using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //get okumak için kullanılır, set ise yazmak için kullanılır.
        //Okuma yapacağımız için sadece get kullanıyoruz.Ctor ile de set edeceğiz.
        bool Success { get; }
        string Message { get; }

    }

}
