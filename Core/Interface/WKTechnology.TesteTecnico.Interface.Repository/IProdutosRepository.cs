using WKTechnology.TesteTecnico.Domain.Entity;

namespace WKTechnology.TesteTecnico.Interface.Repository
{
    public interface IProdutosRepository
    {
        Task<List<Produtos>> GetAll();
        Task Create(Produtos produtos);
        Task Update(Produtos produtos);
        Task<Produtos> GetByGuid(Guid guid);
    }
}
