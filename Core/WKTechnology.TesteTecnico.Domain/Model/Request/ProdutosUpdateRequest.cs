using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Validations;

namespace WKTechnology.TesteTecnico.Domain.Model.Request
{
    public class ProdutosUpdateRequest : ValidationModel
    {
        public required Guid ProdutoGuid { get; set; }
        public required Guid CategoriaGuid { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }

        public bool IsValid()
        {
            ValidationResult = new ProdutosUpdateRequestValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
