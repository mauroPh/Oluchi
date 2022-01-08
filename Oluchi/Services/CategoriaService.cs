using Oluchi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Oluchi.Services
{
    public class CategoriaService
    {
        private readonly OluchiContext _context;

        public CategoriaService(OluchiContext context)
        {
            _context = context;
        }

        public async Task<List<Categoria>> FindAllAsync()
        {
            return await _context.Categoria.OrderBy(x => x.NomeCategoria).ToListAsync();
        }
    }

   
}
