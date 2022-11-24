using Business.Models;
using System.ComponentModel.DataAnnotations;

namespace Banco.MVC.ViewModel
{
    public class ContaFisicaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11,ErrorMessage = "11 Numeros obrigatorios")]
        [Range(0, 99999999999, ErrorMessage = "Apenas numeros.")]
        public string CPF { get; set; }

        [Display(Name = "Agencia")]
        [StringLength(5, ErrorMessage = "5 Numeros obrigatorios")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Apenas numeros.")]
        public string Agencia { get; set; }

        [Display(Name = "ContaCorrente")]
        [StringLength(10, ErrorMessage = "10 Numeros obrigatorios")]
        [Range(0, 99999999999, ErrorMessage = "Apenas numeros.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ContaCorrente { get; set; }

        [Display(Name = "Senha8dig")]
        [StringLength(8, ErrorMessage = "8 Numeros obrigatorios")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Apenas numeros.")]
        public string Senha8dig { get; set; }

        [Display(Name = "Senha6dig")]
        [StringLength(5, ErrorMessage = "5 Numeros obrigatorios")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Apenas numeros.")]
        public string Senha6dig { get; set; }



        public DateTime DataCriacao { get; set; }


    }
}
