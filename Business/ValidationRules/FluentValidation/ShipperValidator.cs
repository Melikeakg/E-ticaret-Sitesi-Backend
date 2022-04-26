using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ShipperValidator:AbstractValidator<Shipper>
    {
        public ShipperValidator()
        {
            RuleFor(s => s.Freight).GreaterThanOrEqualTo(10).WithMessage("Kargo ücreti 10 liradan daha az olamaz");
            RuleFor(s => s.ShipperName).MinimumLength(2).WithMessage("Kargo ismi en az iki karakterden oluşabilir.");
            RuleFor(s => s.ShipperId).NotEmpty();
        }
    }
}
