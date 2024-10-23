using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;

namespace WKTechnology.TesteTecnico.Interface.App
{
    public interface ICategoriasApp
    {
        Task<ResponseObject<List<CategoriasResponse>>> GetAll();
        Task<ResponseObject<Guid>> Create(CategoriasCreateRequest request);
        Task<ResponseObject<bool>> Update(CategoriasUpdateRequest request);
        Task<ResponseObject<bool>> Delete(Guid categoriaGuid);
    }
}
