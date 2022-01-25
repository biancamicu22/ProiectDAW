using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class FotografieRepository : BaseRepository<Fotografie>, IFotografieRepository
    {
        public FotografieRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
