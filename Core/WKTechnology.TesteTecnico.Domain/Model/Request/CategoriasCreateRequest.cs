using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Validations;

namespace WKTechnology.TesteTecnico.Domain.Model.Request
{
    public class CategoriasCreateRequest : ValidationModel
    {
        public string Nome { get; set; }
        public string? Descricao { get; set; }

        public bool IsValid()
        {
            ValidationResult = new CategoriasCreateRequestValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
