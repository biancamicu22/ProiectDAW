using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class RezervareRepository : BaseRepository<Rezervare>, IRezervareRepository
    {
        public RezervareRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
