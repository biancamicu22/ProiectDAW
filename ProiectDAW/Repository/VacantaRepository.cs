using ProiectDAW.Data;
using ProiectDAW.Models;
using System.Linq;
using System.Text.Json;

namespace ProiectDAW.Repository
{
    public class VacantaRepository : BaseRepository<Vacanta>, IVacantaRepository
    {
        public VacantaRepository(DatabaseContext context) : base(context)
        {

        }

        public string VacanteRezervariCazare()
        {
          
            var response =
                from vac in _context.Vacante
                join rezer in _context.RezervariCazari on vac.ID equals rezer.VacantaID
                select new { Rezervare = rezer.CodRezervare, Denumire = vac.Denumire };

            return JsonSerializer.Serialize(response);
        }
    }
}
