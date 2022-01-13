using Oluchi.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;



namespace Oluchi.Models
{
    public class Agenda
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Valor { get; set; }
        public Status Status { get; set; }
        public Artista Artista { get; set; }

        public Agenda()
        {
        }

        public Agenda(int id, DateTime data, double valor, Status status, Artista artista)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Artista = artista;
        }
    }
}
