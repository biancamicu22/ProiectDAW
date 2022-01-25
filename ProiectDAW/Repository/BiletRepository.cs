using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class BiletRepository : BaseRepository<Bilet>, IBiletRepository
    {
        public BiletRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
