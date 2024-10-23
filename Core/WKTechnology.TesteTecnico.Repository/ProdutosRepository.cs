using Microsoft.EntityFrameworkCore;
using WKTechnology.TesteTecnico.Domain.Entity;
using WKTechnology.TesteTecnico.Interface.Repository;

namespace WKTechnology.TesteTecnico.Repository
{
    public class ProdutosRepository : BaseRepository, IProdutosRepository
    {
        public async Task<List<Produtos>> GetAll()
        {
            return await _context.Produtos.Where(w => w.Ativo).ToListAsync();
        }

        public async Task Create(Produtos produtos)
        {
            _context.Produtos.Add(produtos);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Produtos produtos)
        {
            _context.Entry(produtos).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Produtos> GetByGuid(Guid guid)
        {
            return await _context.Produtos.FirstOrDefaultAsync(x => x.ProdutoGuid == guid) ?? new Produtos();
        }
    }
}
