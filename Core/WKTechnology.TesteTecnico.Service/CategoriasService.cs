using AutoMapper;
using WKTechnology.TesteTecnico.Domain.Factory;
using WKTechnology.TesteTecnico.Domain.Model.Common;
using WKTechnology.TesteTecnico.Domain.Model.Request;
using WKTechnology.TesteTecnico.Domain.Model.Response;
using WKTechnology.TesteTecnico.Interface.Repository;
using WKTechnology.TesteTecnico.Interface.Service;

namespace WKTechnology.TesteTecnico.Service
{
    public class CategoriasService : ICategoriasService
    {
        private readonly IMapper _mapper;
        private readonly ICategoriasRepository _repository;

        public CategoriasService(IMapper mapper, ICategoriasRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<int> GetIdByGuid(Guid guid)
        {
            return await _repository.GetIdByGuid(guid);
        }
        
        public async Task<ResponseObject<List<CategoriasResponse>>> GetAll()
        {
            var categorias = await _repository.GetAll();
            return new ResponseObject<List<CategoriasResponse>>(_mapper.Map<List<CategoriasResponse>>(categorias));
        }

        public List<KeyValuePair<int, Guid>> GetAllIdGuid()
        {
            return _repository.GetAllIdGuid();
        }

        public async Task<ResponseObject<Guid>> Create(CategoriasCreateRequest request)
        {
            var entity = CategoriasFactory.New(request);
            await _repository.Create(entity);

            return new ResponseObject<Guid>(entity.CategoriaGuid);
        }

        public async Task<ResponseObject<bool>> Update(CategoriasUpdateRequest request)
        {
            var entityDb = await _repository.GetByGuid(request.CategoriaGuid);
            var entity = CategoriasFactory.Update(entityDb, request);
            
            await _repository.Update(entity);
            return new ResponseObject<bool>(true);
        }

        public async Task<ResponseObject<bool>> Delete(Guid categoriaGuid)
        {
            var entityDb = await _repository.GetByGuid(categoriaGuid);
            var entity = CategoriasFactory.Delete(entityDb);

            await _repository.Update(entity);
            return new ResponseObject<bool>(true);
        }
    }
}
