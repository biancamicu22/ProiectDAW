using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class VacantaRepository : BaseRepository<Vacanta>, IVacantaRepository
    {
        public VacantaRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
