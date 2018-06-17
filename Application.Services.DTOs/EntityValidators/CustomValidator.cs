using Application.Services.DTOs.People;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.DTOs.EntityValidators
{
    class CustomValidator : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                return new ValidationResult($"Поле {validationContext.DisplayName} должно быть заполнено");             
            }
            else
            {
                return ValidationResult.Success;
            }
        }

    }
}
