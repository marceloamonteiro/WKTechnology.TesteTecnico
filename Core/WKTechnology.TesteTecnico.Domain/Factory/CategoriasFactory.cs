using WKTechnology.TesteTecnico.Domain.Entity;
using WKTechnology.TesteTecnico.Domain.Model.Request;

namespace WKTechnology.TesteTecnico.Domain.Factory
{
    public static class CategoriasFactory
    {
        public static Categorias New(CategoriasCreateRequest request)
        {
            return new Categorias
            {
                Nome = request.Nome,
                Descricao = request.Descricao,
                CategoriaGuid = Guid.NewGuid(),
                DataCriacao = DateTime.Now,
                Ativo = true
            };
        }

        public static Categorias Update(Categorias categoria, CategoriasUpdateRequest request)
        {
            categoria.Nome = request.Nome;
            categoria.Descricao = request.Descricao;
            categoria.DataAlteracao = DateTime.Now;

            return categoria;
        }

        public static Categorias Delete(Categorias categoria)
        {
            categoria.Ativo = false;
            categoria.DataAlteracao = DateTime.Now;

            return categoria;
        }
    }
}
