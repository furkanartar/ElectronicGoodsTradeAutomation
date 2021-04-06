using Core.Entities.Concrete;
using Entities.Dtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class AuthRegisterValidator:AbstractValidator<UserForRegisterDto>
    {
        public AuthRegisterValidator()
        {
            RuleFor(user => user.FirstName).NotEmpty();
            RuleFor(user => user.LastName).NotEmpty();
            RuleFor(user => user.Email).NotEmpty();
            RuleFor(user => user.Password).NotEmpty();

            RuleFor(user => user.FirstName).MinimumLength(2);
            RuleFor(user => user.LastName).MinimumLength(2);
            RuleFor(user => user.Email).MinimumLength(2);
            RuleFor(user => user.Password).MinimumLength(6).WithMessage("Parolanız en az 6 karakter olmalı");

            RuleFor(user => user.FirstName).Matches("^[a-zA-Z]*$");
            RuleFor(user => user.LastName).Matches("^[a-zA-Z]*$");
            RuleFor(user => user.Email).Matches(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        }
    }
}