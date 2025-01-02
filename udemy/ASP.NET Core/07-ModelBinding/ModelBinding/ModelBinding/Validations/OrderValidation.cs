using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Validations;
using ModelBinding.Models;

namespace ModelBinding.Validations;

public static class OrderValidation
{
    public static ValidationResult? ValidateDateTime(DateTime date, ValidationContext context)
    {
        if (date < new DateTime(2000, 1, 1))
        {
            return new ValidationResult("OrderDate must be on or after 2000-01-01.");
        }
        return ValidationResult.Success;
    }
}