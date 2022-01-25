using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class AtractieRepository : BaseRepository<Atractie>, IAtractieRepository
    {
        public AtractieRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
