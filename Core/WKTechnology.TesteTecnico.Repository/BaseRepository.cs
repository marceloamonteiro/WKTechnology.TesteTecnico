using WKTechnology.TesteTecnico.Repository.Context;

namespace WKTechnology.TesteTecnico.Repository
{
    public class BaseRepository
    {
        protected readonly MySqlContext _context = new();
    }
}
