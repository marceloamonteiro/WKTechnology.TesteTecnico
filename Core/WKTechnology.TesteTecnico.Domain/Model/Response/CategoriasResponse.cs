namespace WKTechnology.TesteTecnico.Domain.Model.Response
{
    public class CategoriasResponse
    {
        public Guid CategoriaGuid { get; set; }
        public required string Nome { get; set; }
        public string? Descricao { get; set; }
    }
}
