using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Oluchi.Models
{
    public class OluchiContext : DbContext
    {
        public OluchiContext(DbContextOptions<OluchiContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Artista> Artista { get; set; }
        public DbSet<Agenda> Agenda{ get; set; }
    }
}
