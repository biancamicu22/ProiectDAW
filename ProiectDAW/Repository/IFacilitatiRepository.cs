using ProiectDAW.Models;

namespace ProiectDAW.Repository
{
    public interface IFacilitatiRepository : IBaseRepository<Facilitate>
    {
        Facilitate GetByFacilitateId(int facilitateId);
    }
}
