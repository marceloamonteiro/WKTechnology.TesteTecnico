using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WKTechnology.TesteTecnico.Domain.Entity;

namespace WKTechnology.TesteTecnico.Repository.Context
{
    public class MySqlContext : DbContext
    {
        private const string CONNECTION_STRING = "server=127.0.0.1;port=3306;database=wktechnology;uid=root;password=@MySql@TK3M@#20241021#@";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(CONNECTION_STRING, ServerVersion.AutoDetect(CONNECTION_STRING));
        }

        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Categorias> Categorias { get; set; }
    }
}
