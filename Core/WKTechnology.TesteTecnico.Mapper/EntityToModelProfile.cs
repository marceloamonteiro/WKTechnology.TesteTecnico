using AutoMapper;
using WKTechnology.TesteTecnico.Domain.Entity;
using WKTechnology.TesteTecnico.Domain.Model.Response;

namespace WKTechnology.TesteTecnico.Mapper
{
    public class EntityToModelProfile : Profile
    {
        public EntityToModelProfile() 
        {
            CreateMap<Produtos, ProdutosResponse>();
            CreateMap<Categorias, CategoriasResponse>();
        }
    }
}
