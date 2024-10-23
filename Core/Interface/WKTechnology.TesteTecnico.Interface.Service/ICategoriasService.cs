using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;

namespace WKTechnology.TesteTecnico.Interface.Service
{
    public interface ICategoriasService
    {
        Task<int> GetIdByGuid(Guid guid);
        List<KeyValuePair<int, Guid>> GetAllIdGuid();
        Task<ResponseObject<List<CategoriasResponse>>> GetAll();
        Task<ResponseObject<Guid>> Create(CategoriasCreateRequest request);
        Task<ResponseObject<bool>> Update(CategoriasUpdateRequest request);
        Task<ResponseObject<bool>> Delete(Guid categoriaGuid);
    }
}
