using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ClothesValidator:AbstractValidator<Clothes>
    {
        public ClothesValidator()
        {
            RuleFor(c => c.CategoryId).NotEmpty();
            RuleFor(c => c.ClothesName).MinimumLength(3).WithMessage("Kıyafet ismi 3 karakterden büyük olmalıdır.");
            RuleFor(c => c.UnitPrice).GreaterThanOrEqualTo(35).WithMessage("Fiyat en az 35 ₺ olmalıdır.");
        }
    }
}
