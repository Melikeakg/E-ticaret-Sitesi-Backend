using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //iş motoru
        public static IResult Run(params IResult[] logics)
        {
            //parametre ile göndeilen iş kurallarından başarısız olanı business katmanına bildirir.
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }

    }
}
