using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;

namespace WKTechnology.TesteTecnico.Interface.Service
{
    public interface IProdutosService
    {
        Task<ResponseObject<List<ProdutosResponse>>> GetAll();
        Task<ResponseObject<Guid>> Create(ProdutosCreateRequest request);
        Task<ResponseObject<bool>> Update(ProdutosUpdateRequest request);
        Task<ResponseObject<bool>> Delete(Guid produtoGuid);
    }
}
