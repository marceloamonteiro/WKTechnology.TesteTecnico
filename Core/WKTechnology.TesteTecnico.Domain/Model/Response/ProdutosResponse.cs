namespace WKTechnology.TesteTecnico.Domain.Model.Response
{
    public class ProdutosResponse
    {
        public Guid ProdutoGuid { get; set; }
        public Guid CategoriaGuid { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
