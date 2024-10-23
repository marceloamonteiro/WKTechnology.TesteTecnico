using Microsoft.Extensions.DependencyInjection;
using WKTechnology.TesteTecnico.App;
using WKTechnology.TesteTecnico.Interface.App;
using WKTechnology.TesteTecnico.Interface.Repository;
using WKTechnology.TesteTecnico.Interface.Service;
using WKTechnology.TesteTecnico.Repository;
using WKTechnology.TesteTecnico.Service;

namespace WKTechnology.TesteTecnico.IoC
{
    public static class IoCConfig
    {
        public static void Config(IServiceCollection services)
        {
            #region [ App ]

            services.AddTransient<IProdutosApp, ProdutosApp>();
            services.AddTransient<ICategoriasApp, CategoriasApp>();

            #endregion

            #region [ Service ]

            services.AddTransient<IProdutosService, ProdutosService>();
            services.AddTransient<ICategoriasService, CategoriasService>();

            #endregion

            #region [ Repository ]

            services.AddTransient<IProdutosRepository, ProdutosRepository>();
            services.AddTransient<ICategoriasRepository, CategoriasRepository>();

            #endregion
        }
    }
}
