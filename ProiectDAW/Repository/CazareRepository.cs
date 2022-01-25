using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class CazareRepository : BaseRepository<Cazare>, ICazareRepository
    {
        public CazareRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
