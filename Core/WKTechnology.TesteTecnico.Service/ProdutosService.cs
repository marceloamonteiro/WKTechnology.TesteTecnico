using AutoMapper;
using WKTechnology.TesteTecnico.Domain.Entity;
using WKTechnology.TesteTecnico.Domain.Factory;
using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;
using WKTechnology.TesteTecnico.Interface.Repository;
using WKTechnology.TesteTecnico.Interface.Service;

namespace WKTechnology.TesteTecnico.Service
{
    public class ProdutosService : IProdutosService
    {
        private readonly IMapper _mapper;
        private readonly ICategoriasService _service;
        private readonly IProdutosRepository _repository;

        public ProdutosService(IMapper mapper, ICategoriasService service, IProdutosRepository repository)
        {
            _mapper = mapper;
            _service = service;
            _repository = repository;
        }

        public async Task<ResponseObject<List<ProdutosResponse>>> GetAll()
        {
            var produtos = await _repository.GetAll();
            var categoriaGuids = _service.GetAllIdGuid();

            return new ResponseObject<List<ProdutosResponse>>(GetAllResponse(produtos, categoriaGuids));
        }

        public async Task<ResponseObject<Guid>> Create(ProdutosCreateRequest request)
        {
            var categoriaId = await _service.GetIdByGuid(request.CategoriaGuid);
            var entity = ProdutosFactory.New(request, categoriaId);

            await _repository.Create(entity);
            return new ResponseObject<Guid>(entity.ProdutoGuid);
        }

        public async Task<ResponseObject<bool>> Update(ProdutosUpdateRequest request)
        {
            var entityDb = await _repository.GetByGuid(request.ProdutoGuid);
            var entity = ProdutosFactory.Update(entityDb, request);

            await _repository.Update(entity);
            return new ResponseObject<bool>(true);
        }

        public async Task<ResponseObject<bool>> Delete(Guid produtoGuid)
        {
            var entityDb = await _repository.GetByGuid(produtoGuid);
            var entity = ProdutosFactory.Delete(entityDb);

            await _repository.Update(entity);
            return new ResponseObject<bool>(true);
        }

        private List<ProdutosResponse> GetAllResponse(List<Produtos> produtos, List<KeyValuePair<int, Guid>> categoriaGuids)
        {
            var produtosModel = _mapper.Map<List<ProdutosResponse>>(produtos);

            foreach (var item in produtosModel)
                item.CategoriaGuid = GetCategoriaGuidById(produtos.Find(x => x.ProdutoGuid == item.ProdutoGuid)?.CategoriaId ?? 0, categoriaGuids);

            return produtosModel;
        }

        private static Guid GetCategoriaGuidById(int id, List<KeyValuePair<int, Guid>> categoriaGuids) => categoriaGuids.Find(c => c.Key == id).Value;
    }
}
