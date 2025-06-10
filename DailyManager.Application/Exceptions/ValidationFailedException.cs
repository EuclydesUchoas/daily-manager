using DailyManager.Application.Models;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DailyManager.Application.Exceptions
{
    public sealed class ValidationFailedException : Exception
    {
        public readonly IReadOnlyList<ValidationErrorModel> Errors = new List<ValidationErrorModel>();

        internal ValidationFailedException(List<ValidationErrorModel> errors)
            : this("Validation failed.", errors)
        {
        }

        internal ValidationFailedException(ValidationErrorModel error)
            : this("Validation failed.", new List<ValidationErrorModel>() { error })
        {
        }

        internal ValidationFailedException(string message, List<ValidationErrorModel> errors)
            : base(message)
        {
            Errors = errors;
        }

        internal static void ThrowIfValidationResultIsNotValid(ValidationResult validationResult)
        {
            if (!validationResult.IsValid)
            {
                var errors = validationResult.Errors
                    .Select(x => new ValidationErrorModel(x.PropertyName, x.ErrorMessage))
                    .ToList();

                StringBuilder sb = new StringBuilder("Validation failed for the following properties:\n");
                foreach (var error in errors)
                {
                    sb.AppendLine($"- {error.PropertyName}: {error.ErrorMessage}");
                }

                string errorMessage = sb.ToString();

                throw new ValidationFailedException(errorMessage, errors);
            }
        }
    }
}
