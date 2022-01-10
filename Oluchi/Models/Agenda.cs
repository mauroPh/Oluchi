using Oluchi.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;



namespace Oluchi.Models
{
    public class Agenda
    {
        private int v1;
        private DateTime dateTime;
        private int v2;
        private Status confirmado;
        private Artista art1;

        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]

        public string Local{ get; set; }

        public int Apresentacoes { get; set; }
        public Status Status { get; set; }
        public Artista Artista { get; set; }

        public Agenda()
        {
        }

        public Agenda(int id, DateTime date,string local, int apresentacoes, Status status, Artista artista)
        {
            Id = id;
            Date = date;
            Local = local;
            Apresentacoes = apresentacoes;
            Status = status;
            Artista = artista;

        }

        public Agenda(int v1, DateTime dateTime, int v2, Status confirmado, Artista art1)
        {
            this.v1 = v1;
            this.dateTime = dateTime;
            this.v2 = v2;
            this.confirmado = confirmado;
            this.art1 = art1;
        }
    }
}
