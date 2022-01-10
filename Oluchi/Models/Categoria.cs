using System;
using System.Collections.Generic;
using System.Linq;


namespace Oluchi.Models
{
    public class Categoria
    {

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Artista> Artistas { get; set; } = new List<Artista>();

        public Categoria()
        {
        }

        public Categoria(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public void AddArtista(Artista artista)
        {
            Artistas.Add(artista);
        }

        public double Total(DateTime initial, DateTime final)
        {
            return Artistas.Sum(artista => artista.Total(initial, final));
        }

    }
}