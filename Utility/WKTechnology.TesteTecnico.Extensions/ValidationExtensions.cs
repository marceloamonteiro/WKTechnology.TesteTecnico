using FluentValidation.Results;

namespace WKTechnology.TesteTecnico.Extensions
{
    public static class ValidationExtensions
    {
        public static List<string> GetResultErros(this List<ValidationFailure> erros)
        {
            if (!erros.HasValue())
                return [];

            return erros.Select(erro => erro.ErrorMessage).ToList();
        }
    }
}
