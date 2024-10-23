using Microsoft.AspNetCore.Mvc;
using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;
using WKTechnology.TesteTecnico.Interface.App;


namespace WKTechnology.TesteTecnico.Api.Controllers
{
    [ApiController]
    [Route("api/v1/categorias")]
    public class CategoriaController : BaseController
    {
        private readonly ICategoriasApp _app;

        public CategoriaController(ICategoriasApp app)
        {
            _app = app;
        }

        [HttpGet]
        [ProducesResponseType(typeof(ResponseObject<Guid>), 200)]
        [ProducesResponseType(typeof(ResponseObject<Guid>), 400)]
        [ProducesResponseType(typeof(ResponseObject<Guid>), 404)]
        public async Task<IActionResult> GetAll()
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            return Response(await _app.GetAll());
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseObject<List<CategoriasResponse>>), 200)]
        [ProducesResponseType(typeof(ResponseObject<List<CategoriasResponse>>), 400)]
        [ProducesResponseType(typeof(ResponseObject<List<CategoriasResponse>>), 404)]
        public async Task<IActionResult> Create([FromBody] CategoriasCreateRequest request)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            return Response(await _app.Create(request));
        }

        [HttpPut]
        [ProducesResponseType(typeof(ResponseObject<bool>), 200)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 400)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 404)]
        public async Task<IActionResult> Update([FromBody] CategoriasUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            return Response(await _app.Update(request));
        }

        [HttpDelete]
        [Route("{categoriaGuid}")]
        [ProducesResponseType(typeof(ResponseObject<bool>), 200)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 400)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 404)]
        public async Task<IActionResult> Delete(Guid categoriaGuid)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            return Response(await _app.Delete(categoriaGuid));
        }
    }
}
