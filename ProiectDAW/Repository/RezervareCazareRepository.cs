using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class RezervareCazareRepository : BaseRepository<RezervareCazare>, IRezervareCazareRepository
    {
        public RezervareCazareRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
