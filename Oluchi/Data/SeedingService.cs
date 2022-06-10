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
            Categoria cat5 = new Categoria(5, "Desenho");
            





            Artista art1 = new Artista(1, "Caio Prado", "cprado@gmail.com", new DateTime(1998, 4, 21),            1000.0 ,              cat1);
            Artista art2 = new Artista(2, "Xenia França", "xeniafranca@gmail.com", new DateTime(1979, 12, 31),    3500.0 ,      cat2);
            Artista art3 = new Artista(3, "Elisa Fernandes", "efernandes@gmail.com", new DateTime(1988, 1, 15),   2200.0 ,    cat3);
            Artista art4 = new Artista(4, "Giovani Cidreira", "gcidreira@gmail.com", new DateTime(1993, 11, 30),  3000.0 ,    cat4);
            Artista art5 = new Artista(5, "Abdias Nascimento", "abnascimento@gmail.com", new DateTime(2000, 1, 9),4000.0 ,  cat5);
            








            Agenda ag1 = new Agenda(  1, new DateTime(2022, 01, 25),11000.0, Status.Confirmado, art1);
            Agenda ag2 = new Agenda(  2, new DateTime(2022, 01, 4),  7000.0, Status.Confirmado, art5);
            Agenda ag3 = new Agenda(  3, new DateTime(2022,01, 13),  4000.0, Status.Cancelado, art4);
            Agenda ag4 = new Agenda(  4, new DateTime(2022, 01, 1),  8000.0, Status.Confirmado, art1);
            Agenda ag5 = new Agenda(  5, new DateTime(2021, 12, 21), 3000.0, Status.Confirmado, art3);
            Agenda ag6 = new Agenda(  6, new DateTime(2021, 12, 15), 2000.0, Status.Confirmado, art1);
            Agenda ag7 = new Agenda(  7, new DateTime(2021, 12, 28),13000.0, Status.Confirmado, art2);
            Agenda ag8 = new Agenda(  8, new DateTime(2021, 12, 11), 4000.0, Status.Confirmado, art4);
            Agenda ag9 = new Agenda(  9, new DateTime(2021, 12, 14),11000.0, Status.Pendente, art2);
            Agenda ag10 = new Agenda(10, new DateTime(2022, 09, 7),  9000.0, Status.Confirmado, art3);
            Agenda ag11 = new Agenda(11, new DateTime(2022, 01, 13), 6000.0, Status.Confirmado, art2);
            Agenda ag12 = new Agenda(12, new DateTime(2022, 01, 25), 7000.0, Status.Pendente, art3);
            Agenda ag13 = new Agenda(13, new DateTime(2022, 01, 29),10000.0, Status.Confirmado, art4);
            Agenda ag14 = new Agenda(14, new DateTime(2022, 01, 4),  3000.0, Status.Confirmado, art5);
            Agenda ag15 = new Agenda(15, new DateTime(2022, 02, 12), 4000.0, Status.Confirmado, art1);
            Agenda ag16 = new Agenda(16, new DateTime(2022, 02, 5),  2000.0, Status.Confirmado, art4);
            Agenda ag17 = new Agenda(17, new DateTime(2022, 02, 1), 12000.0, Status.Confirmado, art1);
            Agenda ag18 = new Agenda(18, new DateTime(2022, 02, 24), 6000.0, Status.Confirmado, art3);
            Agenda ag19 = new Agenda(19, new DateTime(2022, 02, 22), 8000.0, Status.Confirmado, art5);
            Agenda ag20 = new Agenda(20, new DateTime(2022, 02, 15), 8000.0, Status.Confirmado, art4);
            Agenda ag21 = new Agenda(21, new DateTime(2022, 03, 17), 9000.0, Status.Confirmado, art2);
            Agenda ag22 = new Agenda(22, new DateTime(2022, 03, 24), 4000.0, Status.Confirmado, art4);
            Agenda ag23 = new Agenda(23, new DateTime(2022, 03, 19),11000.0, Status.Cancelado, art2);
            Agenda ag24 = new Agenda(24, new DateTime(2022, 03, 12), 8000.0, Status.Confirmado, art5);
            Agenda ag25 = new Agenda(25, new DateTime(2022, 03, 31), 7000.0, Status.Confirmado, art3);
            Agenda ag26 = new Agenda(26, new DateTime(2022, 03, 6),  5000.0, Status.Confirmado, art4);
            Agenda ag27 = new Agenda(27, new DateTime(2022, 03, 13), 9000.0, Status.Pendente, art1);
            Agenda ag28 = new Agenda(28, new DateTime(2022, 03, 7),  4000.0, Status.Confirmado, art3);
            Agenda ag29 = new Agenda(29, new DateTime(2022, 03, 23),12000.0, Status.Confirmado, art5);
            Agenda ag30 = new Agenda(30, new DateTime(2022, 03, 12), 5000.0, Status.Confirmado, art2);
            Agenda ag31= new Agenda(31, new DateTime(2022, 01, 25), 11000.0, Status.Confirmado, art5);
            Agenda ag32= new Agenda(32, new DateTime(2022, 01, 4), 7000.0, Status.Confirmado, art1);
            Agenda ag33= new Agenda(33, new DateTime(2022, 01, 13), 4000.0, Status.Cancelado, art1);
            Agenda ag34= new Agenda(34, new DateTime(2022, 01, 1), 8000.0, Status.Confirmado, art2);
            Agenda ag35= new Agenda(35, new DateTime(2021, 12, 21), 3000.0, Status.Confirmado, art1);
            Agenda ag36= new Agenda(36, new DateTime(2021, 12, 15), 2000.0, Status.Confirmado, art2);
            Agenda ag37= new Agenda(37, new DateTime(2021, 12, 28), 13000.0, Status.Confirmado, art3);
            Agenda ag38= new Agenda(38, new DateTime(2021, 12, 11), 4000.0, Status.Confirmado, art4);
            Agenda ag39= new Agenda(39, new DateTime(2021, 12, 14), 11000.0, Status.Pendente, art5);
            Agenda ag40 = new Agenda(40, new DateTime(2022, 09, 7), 9000.0, Status.Confirmado, art3);
            Agenda ag41 = new Agenda(41, new DateTime(2022, 01, 25), 11000.0, Status.Confirmado, art2);
            
            _context.Categoria.AddRange(
                cat1, cat2, cat3, cat4, cat5);

            _context.Artista.AddRange(
                art1, art2, art3, art4, art5);

            _context.Agenda.AddRange(
                ag1, ag2, ag3, ag4, ag5, ag6, ag7, ag8, ag9, ag10,
                ag11, ag12, ag13, ag14, ag15, ag16, ag17, ag18, ag19, ag20,
                ag21, ag22, ag23, ag24, ag25, ag26, ag27, ag28, ag29, ag30,
                ag31, ag32, ag33, ag34, ag35, ag36, ag37, ag38, ag39, ag40,
                ag41
            );

            _context.SaveChanges();
        }
    }
}

