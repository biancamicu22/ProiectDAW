using ProiectDAW.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProiectDAW.Repository
{
    public interface ICazareRepository : IBaseRepository<Cazare>
    {
       void getCazareGroupBy();
    }
}
