using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oluchi.Models;

namespace Oluchi.Services
{
    public class AgendaService
    {

        private readonly OluchiContext _context;

        public AgendaService(OluchiContext context)
        {
            _context = context;
        }

        public async Task<List<Agenda>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Agenda select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Artista)
                .Include(x => x.Artista.Categoria)
                .OrderByDescending(x => x.Data)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Categoria, Agenda>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Agenda select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Data >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Data <= maxDate.Value);
            }
            return await result
                .Include(x => x.Artista)
                .Include(x => x.Artista.Categoria)
                .OrderByDescending(x => x.Data)
                .GroupBy(x => x.Artista.Categoria)
                .ToListAsync();
        }



    }
}
