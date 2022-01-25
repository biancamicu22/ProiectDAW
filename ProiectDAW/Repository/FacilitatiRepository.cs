using ProiectDAW.Data;
using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public class FacilitatiRepository :BaseRepository<Facilitate>,IFacilitatiRepository
    {
        public FacilitatiRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
