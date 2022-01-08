using Oluchi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Oluchi.Services.Exceptions;

namespace Oluchi.Services
{
    public class ArtistaService
    {


        private readonly OluchiContext _context;

        public ArtistaService(OluchiContext context)
        {
            _context = context;
        }

        public async Task<List<Artista>> FindAllAsync()
        {
            return await _context.Artista.ToListAsync();
        }

        public async Task InsertAsync(Artista obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Artista> FindByIdAsync(int id)
        {
            return await _context.Artista.Include(obj => obj.Categoria).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var obj = await _context.Artista.FindAsync(id);
                _context.Artista.Remove(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Não é póssível deletar.");
            }
        }

        public async Task UpdateAsync(Artista obj)
        {
            bool hasAny = await _context.Artista.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("CPF não encontrado");
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }




    }
}
