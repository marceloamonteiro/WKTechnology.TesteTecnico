using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Validations;

namespace WKTechnology.TesteTecnico.Domain.Model.Request
{
    public class ProdutosCreateRequest : ValidationModel
    {
        public Guid CategoriaGuid { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }

        public bool IsValid()
        {
            ValidationResult = new ProdutosCreateRequestValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
