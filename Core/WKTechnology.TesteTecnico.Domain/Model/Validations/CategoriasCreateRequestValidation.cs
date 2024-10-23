using FluentValidation;
using FluentValidation.Results;
using WKTechnology.TesteTecnico.Domain.Model.Request;

namespace WKTechnology.TesteTecnico.Domain.Model.Validations
{
    public class CategoriasCreateRequestValidation : AbstractValidator<CategoriasCreateRequest>
    {
        public CategoriasCreateRequestValidation()
        {
            ValidateRequest();
        }

        private void ValidateRequest()
        {
            RuleFor(p => p)
                .Custom((obj, context) =>
                {
                    if (string.IsNullOrWhiteSpace(obj.Nome))
                        context.AddFailure(new ValidationFailure() { ErrorMessage = "Nome da categoria é nulo ou inválido." });
                });
        }
    }
}
