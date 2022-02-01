using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using ProiectDAW.Data;
using ProiectDAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace ProiectDAW.Repository
{
    public class BiletRepository : BaseRepository<Bilet>, IBiletRepository
    {
        public BiletRepository(DatabaseContext context) : base(context)
        {
        }

        public List<Bilet> getBileteConditioned()
        {
            var bilete = _context.Set<Bilet>().AsEnumerable();
            var startDate = DateTime.Parse("01/01/2022 00:00:00");
            var endDate = DateTime.Parse("31/01/2022 00:00:00");
            var result = bilete.Where(bilet => bilet.DataVizita.Date > startDate.Date && bilet.DataVizita.Date < endDate.Date);

            return result.ToList();
        }
    }
}
