using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProiectDAW.Data;
using ProiectDAW.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ProiectDAW.Repository
{
    public class CazareRepository : BaseRepository<Cazare>, ICazareRepository
    {
        public CazareRepository(DatabaseContext context) : base(context)
        {


        }

        public void getCazareGroupBy()
        {
            var x = _context.Set<Cazare>().AsEnumerable();
            var y = x.GroupBy(x => x.Pret);
            foreach (var cazare in y)
            {
                {
                    System.Diagnostics.Debug.WriteLine("Cazari cu pretul: " + cazare.Key);
                    foreach (Cazare u in cazare)
                    {
                        System.Diagnostics.Debug.WriteLine(u.Nume);
                    }
                }
            }
        }

        public List<Cazare> getCazareRezervare()
        {
            return _context.Cazari.Include(c => c.RezervareCazare).ToList();
        }
    }
}
