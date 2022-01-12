using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace Oluchi.Models
{
    public class Artista
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} Campo obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} deve conter entre {2} e {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} Campo obrigatório")]
        [EmailAddress(ErrorMessage = "Digite um email válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Campo obrigatório")]
        [Display(Name = "Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "{0} Campo obrigatório")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} deve estar entre {1} e {2}")]
        [Display(Name = "Valor Base")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double ValorBase { get; set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public ICollection<Agenda> Sales { get; set; } = new List<Agenda>();

        public Artista()
        {
        }

        public Artista(int id, string nome, string email, DateTime birthDate, double valorBase, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Email = email;
            BirthDate = birthDate;
            ValorBase= valorBase;
            Categoria = categoria;
        }

        public void AddSales(Agenda sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(Agenda sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Data >= initial && sr.Data <= final).Sum(sr => sr.Valor);
        }
    }
}
