using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oluchi.Models;
using Oluchi.Models.Enums;


namespace Oluchi.Data
{
    public class SeedingService
    {
        private OluchiContext _context;

        public SeedingService(OluchiContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Categoria.Any() ||
                _context.Artista.Any() ||
                _context.Agenda.Any())
            {
                return; // DB já foi populado.
            }








            //******//

        }
    }
}
