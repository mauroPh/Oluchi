using System;
using System.Collections.Generic;
using System.Linq;


namespace Oluchi.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NomeCategoria { get; set; }

        public string Descricao { get; set; }

        public DateTime DataExposicao { get; set; }

        public ICollection<Artista> Artistas { get; set; } = new List<Artista>();

        public Categoria()
        {
        }

        public Categoria(int id, string nomeCategoria, string descricao, DateTime dataExposicao)
        {
            Id = id;
            NomeCategoria = nomeCategoria;
            Descricao = descricao;
            DataExposicao = dataExposicao;
        }

        public void AddArtista(Artista artista)
        {
            Artistas.Add(artista);
        }

        public double TotalApresentacoes(DateTime initial, DateTime final)
        {
            return Artistas.Sum(artista => artista.TotalApresentacoes(initial, final));
        }


    }
}
