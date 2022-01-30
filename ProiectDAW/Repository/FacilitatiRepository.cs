using ProiectDAW.Data;
using ProiectDAW.Models;
using System.Linq;

namespace ProiectDAW.Repository
{
    public class FacilitatiRepository :BaseRepository<Facilitate>,IFacilitatiRepository
    {
        public FacilitatiRepository(DatabaseContext context) : base(context)
        {
        }

        public Facilitate GetByFacilitateId(int facilitateId)
        {
            var fac = _context.Facilitati.Where(x=> x.FacilitateId == facilitateId).ToArray();
            return fac[0];
        }
    }
}
