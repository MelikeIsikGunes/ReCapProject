using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity); //car türü için doğrulama contexti oluştur
            var result = validator.Validate(context);
            if (!result.IsValid) //sonuç geçerli değilse hata fırlat(doğrulama kurallarına uymuyorsa)
            {
                throw new ValidationException(result.Errors);
            }
        }
        
    }
}
