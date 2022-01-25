using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class PortofelRepository : BaseRepository<Portofel>, IPortofelRepository
    {
        public PortofelRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
