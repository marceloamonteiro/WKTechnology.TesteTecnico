using WKTechnology.TesteTecnico.Domain.Entity;
using WKTechnology.TesteTecnico.Domain.Model.Common;

namespace WKTechnology.TesteTecnico.Interface.Repository
{
    public interface ICategoriasRepository
    {
        Task<List<Categorias>> GetAll();
        Task<int> GetIdByGuid(Guid guid);
        Task Create(Categorias categorias);
        Task Update(Categorias categorias);
        Task<Categorias> GetByGuid(Guid guid);
        List<KeyValuePair<int, Guid>> GetAllIdGuid();
    }
}
