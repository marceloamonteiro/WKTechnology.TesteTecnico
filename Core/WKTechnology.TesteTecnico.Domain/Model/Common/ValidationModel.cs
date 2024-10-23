using FluentValidation.Results;
using System.Text.Json.Serialization;

namespace WKTechnology.TesteTecnico.Domain.Model.Common
{
    public abstract class ValidationModel
    {
        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; } = new ValidationResult();
    }
}
