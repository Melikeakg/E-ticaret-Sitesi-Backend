using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //IResult interface'inin somut sınıfını yazıyoruz.
    //IResult result'in referansını tutabilir.
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
            //get readonly'dir ve ctor ile set edilebilir.
            //Message'i ctor ile set ediyoruz.
        }

        public Result(bool succes)
        {
            Success = succes;
            //Sadece true-false bilgisini vermek isteyebiliriz.
            //Buna overloading denir.
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
