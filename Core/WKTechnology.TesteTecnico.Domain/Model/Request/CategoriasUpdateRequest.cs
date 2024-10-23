using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Validations;

namespace WKTechnology.TesteTecnico.Domain.Model.Request
{
    public class CategoriasUpdateRequest : ValidationModel
    {
        public required Guid CategoriaGuid { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }

        public bool IsValid()
        {
            ValidationResult = new CategoriasUpdateRequestValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
