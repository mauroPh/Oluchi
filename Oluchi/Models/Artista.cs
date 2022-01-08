using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Oluchi.Models
{
    public class Artista
    {
        [Required(ErrorMessage = "{0} Informe um CPF válido")]
        [StringLength(11, ErrorMessage = "O {0} deve conter {1} caracteres")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "{0} Informe um nome para cadastro")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O {0} deve conter no mínimo {2} e no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} Informe um endereço de e-mail ")]
        [EmailAddress(ErrorMessage = "Insira um e-mail válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} Informe um telefone para contato ")]
        [EmailAddress(ErrorMessage = "Insira um telefone válido")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "{0} Campo obrigatório")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Você deve informar uma breve descrição.")]
        [Display(Name = "Descrição do seu trabalho")]
        public string Descricao { get; set; }

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }


        public ICollection<Agenda> QtdDiasApresentacao { get; set; } = new List<Agenda>();

        public Artista()
        {
        }

        public Artista(int cpf, string nome, string email, string phone, DateTime birthDate, string descricao, Categoria categoria)
        {
            CPF = cpf;
            Nome = nome;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
            Descricao = descricao;
            Categoria = categoria;
                            
        }

        public void AddApresentacao (Agenda ag)
        {
            QtdDiasApresentacao.Add( ag);
        }

        public void RemoveApresentacao(Agenda ag)
        {
            QtdDiasApresentacao.Remove(ag);
        }

        public double TotalApresentacoes(DateTime initial, DateTime final)
        {
            return QtdDiasApresentacao.Where(ag => ag.Date >= initial && ag.Date <= final).Sum(ag => ag.QtdDiasApresentacao);
        }




    }
}