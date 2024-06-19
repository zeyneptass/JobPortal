using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).NotEmpty();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.RoleId).NotEmpty();
            RuleFor(u => u.Password).MinimumLength(8);
            RuleFor(u => u.Password).Must(PasswordExtraRules).WithMessage("Please, repeat again.");
        }

        private bool PasswordExtraRules(string arg)
        {
            bool hasUpperChar = arg.Any(char.IsUpper);
            bool hasLowerChar = arg.Any(char.IsLower);
            bool hasDigit = arg.Any(char.IsDigit);
            bool hasSpecialChar = arg.Any(ch => !char.IsLetterOrDigit(ch));

            return hasUpperChar && hasLowerChar && hasDigit && hasSpecialChar;
        }
    }
}
