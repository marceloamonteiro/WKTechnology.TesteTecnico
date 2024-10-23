using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;
using WKTechnology.TesteTecnico.Interface.App;
using WKTechnology.TesteTecnico.Interface.Service;
using WKTechnology.TesteTecnico.Extensions;

namespace WKTechnology.TesteTecnico.App
{
    public class CategoriasApp : BaseApp, ICategoriasApp
    {
        private readonly ICategoriasService _service;

        public CategoriasApp(ICategoriasService service)
        {
            _service = service;
        }

        public async Task<ResponseObject<List<CategoriasResponse>>> GetAll()
        {
            try
            {
                return await _service.GetAll();
            }
            catch (Exception ex)
            {
                return new ResponseObject<List<CategoriasResponse>>(GetNotifications(ex.Message));
            }
        }

        public async Task<ResponseObject<Guid>> Create(CategoriasCreateRequest request)
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

        public async Task<ResponseObject<bool>> Update(CategoriasUpdateRequest request)
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

        public async Task<ResponseObject<bool>> Delete(Guid categoriaGuid)
        {
            try
            {
                return await _service.Delete(categoriaGuid);
            }
            catch (Exception ex)
            {
                return new ResponseObject<bool>(GetNotifications(ex.Message));
            }
        }
    }
}
