using WKTechnology.TesteTecnico.Domain.Entity;
using WKTechnology.TesteTecnico.Domain.Model.Request;

namespace WKTechnology.TesteTecnico.Domain.Factory
{
    public static class ProdutosFactory
    {
        public static Produtos New(ProdutosCreateRequest request, int categoriaId)
        {
            return new Produtos
            {
                Nome = request.Nome,
                CategoriaId = categoriaId,
                Descricao = request.Descricao,
                ProdutoGuid = Guid.NewGuid(),
                DataCriacao = DateTime.Now,
                Ativo = true
            };
        }

        public static Produtos Update(Produtos produto, ProdutosUpdateRequest request)
        {
            produto.Nome = request.Nome;
            produto.Descricao = request.Descricao;
            produto.DataAlteracao = DateTime.Now;

            return produto;
        }

        public static Produtos Delete(Produtos produto)
        {
            produto.Ativo = false;
            produto.DataAlteracao = DateTime.Now;

            return produto;
        }
    }
}
