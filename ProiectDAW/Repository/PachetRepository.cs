using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class PachetRepository : BaseRepository<Pachet>, IPachetRepository
    {
        public PachetRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
