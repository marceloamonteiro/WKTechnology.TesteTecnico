using Microsoft.EntityFrameworkCore;
using WKTechnology.TesteTecnico.Domain.Entity;
using WKTechnology.TesteTecnico.Interface.Repository;

namespace WKTechnology.TesteTecnico.Repository
{
    public class CategoriasRepository : BaseRepository, ICategoriasRepository
    {
        public async Task<int> GetIdByGuid(Guid guid)
        {
            var categoria = await _context.Categorias.FirstOrDefaultAsync(x => x.CategoriaGuid == guid);
            return categoria?.CategoriaId ?? 0;
        }

        public async Task<List<Categorias>> GetAll()
        {
            return await _context.Categorias.Where(w => w.Ativo).ToListAsync();
        }

        public async Task Create(Categorias categorias)
        {
            _context.Categorias.Add(categorias);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Categorias categorias)
        {
            _context.Entry(categorias).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Categorias> GetByGuid(Guid guid)
        {
            return await _context.Categorias.FirstOrDefaultAsync(x => x.CategoriaGuid == guid) ?? new Categorias();
        }

        public List<KeyValuePair<int, Guid>> GetAllIdGuid()
        {
            return [.. _context.Categorias.Where(w => w.Ativo).ToDictionary(e => e.CategoriaId, e => e.CategoriaGuid)];
        }
    }
}
