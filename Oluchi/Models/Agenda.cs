using Oluchi.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;



namespace Oluchi.Models
{
    public class Agenda
    {

        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]

        public string Local{ get; set; }

        public int QtdDiasApresentacao { get; set; }
        public Status Status { get; set; }
        public Artista Artista { get; set; }

        public Agenda()
        {
        }

        public Agenda(int id, DateTime date,string local, int qtdDiasApresentacao, Status status, Artista artista)
        {
            Id = id;
            Date = date;
            Local = local;
            QtdDiasApresentacao = qtdDiasApresentacao;
            Status = status;
            Artista = artista;

        }





        
    }
}
