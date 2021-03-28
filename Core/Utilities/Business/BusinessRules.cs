using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //params-parametre olarak istediğimiz kadar IResult ekleyebiliriz
        {
            foreach (var logic in logics) //her bir iş kuralını gez
            {
                if (!logic.Success)
                {
                    return logic; //parametre olarak gönderilen iş kurallarından hatalı olanı gönder
                }
            }

            return null; //başarılıysa bir şey göndermeye gerek yok
        }
    }
}
