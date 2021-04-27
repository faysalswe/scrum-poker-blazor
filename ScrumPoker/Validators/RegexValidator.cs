using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ScrumPoker.Validators
{
    public class RegexValidator: ValidationAttribute
    {
        public string Pattern { get; set; }

        protected override ValidationResult IsValid(
                object value,
                ValidationContext validationContext
            )
        {
            Regex regex = new Regex(Pattern);
            if (!regex.IsMatch(value.ToString()))
            {
                return null;
            }

            return new ValidationResult($"username only allow lower case without space",
            new[] { validationContext.MemberName });
        }
    }
}
