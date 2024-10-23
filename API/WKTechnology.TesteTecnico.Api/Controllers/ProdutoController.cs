using Microsoft.AspNetCore.Mvc;
using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;
using WKTechnology.TesteTecnico.Interface.App;

namespace WKTechnology.TesteTecnico.Api.Controllers
{
    [ApiController]
    [Route("api/v1/produtos")]
    public class ProdutoController : BaseController
    {
        private readonly IProdutosApp _app;

        public ProdutoController(IProdutosApp app)
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
        [ProducesResponseType(typeof(ResponseObject<List<ProdutosResponse>>), 200)]
        [ProducesResponseType(typeof(ResponseObject<List<ProdutosResponse>>), 400)]
        [ProducesResponseType(typeof(ResponseObject<List<ProdutosResponse>>), 404)]
        public async Task<IActionResult> Create([FromBody] ProdutosCreateRequest request)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            return Response(await _app.Create(request));
        }

        [HttpPut]
        [ProducesResponseType(typeof(ResponseObject<bool>), 200)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 400)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 404)]
        public async Task<IActionResult> Update([FromBody] ProdutosUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            return Response(await _app.Update(request));
        }

        [HttpDelete]
        [Route("{produtoGuid}")]
        [ProducesResponseType(typeof(ResponseObject<bool>), 200)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 400)]
        [ProducesResponseType(typeof(ResponseObject<bool>), 404)]
        public async Task<IActionResult> Delete(Guid produtoGuid)
        {
            if (!ModelState.IsValid)
                return ValidationProblem();

            return Response(await _app.Delete(produtoGuid));
        }
    }
}
