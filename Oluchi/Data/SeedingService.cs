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




            Categoria cat1 = new Categoria(1, "Teatro");
            Categoria cat2 = new Categoria(2, "Música");
            Categoria cat3 = new Categoria(3, "Gastronomia");
            Categoria cat4 = new Categoria(4, "Dança");

            Artista art1 = new Artista(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 35, cat1);
            Artista art2 = new Artista(2, "Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 75, cat2);
            Artista art3 = new Artista(3, "Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 120, cat1);
            Artista art4 = new Artista(4, "Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 30, cat4);
            Artista art5 = new Artista(5, "Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 40, cat3);
            Artista art6 = new Artista(6, "Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 98, cat2);

            Agenda ag1 = new Agenda(1, new DateTime(2018, 09, 25), 3, Status.Confirmado, art1);
            Agenda ag2 = new Agenda(2, new DateTime(2018, 09, 4), 4, Status.Confirmado, art5);
            Agenda ag3 = new Agenda(3, new DateTime(2018, 09, 13), 4, Status.Cancelado, art4);
            Agenda ag4 = new Agenda(4, new DateTime(2018, 09, 1), 8, Status.Confirmado, art1);
            Agenda ag5 = new Agenda(5, new DateTime(2018, 09, 21), 3, Status.Confirmado, art3);
            Agenda ag6 = new Agenda(6, new DateTime(2018, 09, 15), 2, Status.Confirmado, art1);
            Agenda ag7 = new Agenda(7, new DateTime(2018, 09, 28), 1, Status.Confirmado, art2);
            Agenda ag8 = new Agenda(8, new DateTime(2018, 09, 11), 4, Status.Confirmado, art4);
            Agenda ag9 = new Agenda(9, new DateTime(2018, 09, 14), 11, Status.Pendente, art6);
            Agenda ag10 = new Agenda(10, new DateTime(2018, 09, 7), 9, Status.Confirmado, art6);
            Agenda ag11 = new Agenda(11, new DateTime(2018, 09, 13), 6, Status.Confirmado, art2);
            Agenda ag12 = new Agenda(12, new DateTime(2018, 09, 25), 7, Status.Pendente, art3);
            Agenda ag13 = new Agenda(13, new DateTime(2018, 09, 29), 10, Status.Confirmado, art4);
            Agenda ag14 = new Agenda(14, new DateTime(2018, 09, 4), 30, Status.Confirmado, art5);
            Agenda ag15 = new Agenda(15, new DateTime(2018, 09, 12), 40, Status.Confirmado, art1);
            Agenda ag16 = new Agenda(16, new DateTime(2018, 10, 5), 20, Status.Confirmado, art4);
            Agenda ag17 = new Agenda(17, new DateTime(2018, 10, 1), 12, Status.Confirmado, art1);
            Agenda ag18 = new Agenda(18, new DateTime(2018, 10, 24), 6, Status.Confirmado, art3);
            Agenda ag19 = new Agenda(19, new DateTime(2018, 10, 22), 8, Status.Confirmado, art5);
            Agenda ag20 = new Agenda(20, new DateTime(2018, 10, 15), 80, Status.Confirmado, art6);
            Agenda ag21 = new Agenda(21, new DateTime(2018, 10, 17), 90, Status.Confirmado, art2);
            Agenda ag22 = new Agenda(22, new DateTime(2018, 10, 24), 40, Status.Confirmado, art4);
            Agenda ag23 = new Agenda(23, new DateTime(2018, 10, 19), 11, Status.Cancelado, art2);
            Agenda ag24 = new Agenda(24, new DateTime(2018, 10, 12), 80, Status.Confirmado, art5);
            Agenda ag25 = new Agenda(25, new DateTime(2018, 10, 31), 70, Status.Confirmado, art3);
            Agenda ag26 = new Agenda(26, new DateTime(2018, 10, 6), 50, Status.Confirmado, art4);
            Agenda ag27 = new Agenda(27, new DateTime(2018, 10, 13), 9, Status.Pendente, art1);
            Agenda ag28 = new Agenda(28, new DateTime(2018, 10, 7), 4, Status.Confirmado, art3);
            Agenda ag29 = new Agenda(29, new DateTime(2018, 10, 23), 12, Status.Confirmado, art5);
            Agenda ag30 = new Agenda(30, new DateTime(2018, 10, 12), 5, Status.Confirmado, art2);

            _context.Categoria.AddRange(cat1, cat2, cat3, cat4);

            _context.Artista.AddRange(art1, art2, art3, art4, art5, art6);

            _context.Agenda.AddRange(
                ag1, ag2, ag3, ag4, ag5, ag6, ag7, ag8, ag9, ag10,
                ag11, ag12, ag13, ag14, ag15, ag16, ag17, ag18, ag19, ag20,
                ag21, ag22, ag23, ag24, ag25, ag26, ag27, ag28, ag29, ag30
            );

            _context.SaveChanges();
        }
    }
}

