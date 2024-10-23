using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WKTechnology.TesteTecnico.Domain.Entity
{
    [Table("produtos")]
    public class Produtos
    {
        [Key]
        public int ProdutoId { get; set; }
        public Guid ProdutoGuid { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string? Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public bool Ativo { get; set; }
    }
}
