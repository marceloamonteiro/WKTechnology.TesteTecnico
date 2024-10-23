using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;
using WKTechnology.TesteTecnico.Interface.App;
using WKTechnology.TesteTecnico.Interface.Service;
using WKTechnology.TesteTecnico.Extensions;

namespace WKTechnology.TesteTecnico.App
{
    public class ProdutosApp : BaseApp, IProdutosApp
    {
        private readonly IProdutosService _service;

        public ProdutosApp(IProdutosService service)
        {
            _service = service;
        }

        public async Task<ResponseObject<Guid>> Create(ProdutosCreateRequest request)
        {
            if (!request.IsValid())
                return new ResponseObject<Guid>(GetNotifications(request.ValidationResult.Errors.GetResultErros()));

            try
            {
                return await _service.Create(request);
            }
            catch (Exception ex)
            {
                return new ResponseObject<Guid>(GetNotifications(ex.Message));
            }
        }

        public async Task<ResponseObject<List<ProdutosResponse>>> GetAll()
        {
            try
            {
                return await _service.GetAll();
            }
            catch (Exception ex)
            {
                return new ResponseObject<List<ProdutosResponse>>(GetNotifications(ex.Message));
            }
        }

        public async Task<ResponseObject<bool>> Update(ProdutosUpdateRequest request)
        {
            if (!request.IsValid())
                return new ResponseObject<bool>(GetNotifications(request.ValidationResult.Errors.GetResultErros()));

            try
            {
                return await _service.Update(request);
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(GetNotifications(ex.Message));
            }
        }

        public async Task<ResponseObject<bool>> Delete(Guid produtoGuid)
        {
            try
            {
                return await _service.Delete(produtoGuid);
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(GetNotifications(ex.Message));
            }
        }
    }
}
