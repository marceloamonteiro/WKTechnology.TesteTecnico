using FluentValidation;
using FluentValidation.Results;
using WKTechnology.TesteTecnico.Domain.Model.Request;

namespace WKTechnology.TesteTecnico.Domain.Model.Validations
{
    public class ProdutosCreateRequestValidation : AbstractValidator<ProdutosCreateRequest>
    {
        public ProdutosCreateRequestValidation()
        {
            ValidateRequest();
        }

        private void ValidateRequest()
        {
            RuleFor(p => p)
                .Custom((obj, context) =>
                {
                    if (obj.CategoriaGuid == Guid.Empty)
                        context.AddFailure(new ValidationFailure() { ErrorMessage = "CategoriaGuid do produto é nulo ou inválido." });

                    if (string.IsNullOrWhiteSpace(obj.Nome))
                        context.AddFailure(new ValidationFailure() { ErrorMessage = "Nome do produto é nulo ou inválido." });
                });
        }
    }
}
