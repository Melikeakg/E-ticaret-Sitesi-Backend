using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Success ve message bilgilerini de içermesi gerektiği için IResult implementasyonu yaptık.
    //IDataResult interface'i IResult interface'ini implemente ediyor. 
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
