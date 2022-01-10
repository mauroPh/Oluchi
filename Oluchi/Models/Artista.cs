using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Oluchi.Models
{
    public class Artista
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Informe seu nome")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve conter entre {2} e {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "É necessário informar{0}.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "É necessário informar{0}.")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "É necessário informar a duração da exibição(Ex: 1 ou 2 dias).")]
        [Display(Name = "Duração da exibição")]
        public int Exibicoes{ get; set; }

        public Categoria Categoria{ get; set; }
        public int CategoriaId { get; set; }

        public ICollection<Agenda> Apresentacoes{ get; set; } = new List<Agenda>();

        public Artista()
        {
        }

        public Artista(int id, string nome, string email, DateTime birthDate, int exibicoes, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
            Exibicoes = exibicoes;
            Categoria = categoria;
        }

        public void AddApresentacao (Agenda ag)
        {
            Apresentacoes.Add( ag);
        }

        public void RemoveApresentacao(Agenda ag)
        {
            Apresentacoes.Remove(ag);
        }

        public double Total(DateTime initial, DateTime final)
        {
            return Apresentacoes.Where(ag => ag.Date >= initial && ag.Date <= final).Sum(ag => ag.Apresentacoes);
        }




    }
}