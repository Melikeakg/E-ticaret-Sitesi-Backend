using Core.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).MinimumLength(2).WithMessage("Kullanıcı adı iki karakterden az olamaz.");
            RuleFor(u => u.LastName).MinimumLength(2).WithMessage("Kullanıcı soyadı iki karakterden az olamaz.");
            RuleFor(u => u.Email).EmailAddress().WithMessage("Epostanız doğru değil.");
        }
    }
}
