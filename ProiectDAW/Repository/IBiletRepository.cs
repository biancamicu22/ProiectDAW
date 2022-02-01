using ProiectDAW.Models;
using System.Collections.Generic;

namespace ProiectDAW.Repository
{
    public interface IBiletRepository : IBaseRepository<Bilet>
    {
        List<Bilet> getBileteConditioned();
    }
}
