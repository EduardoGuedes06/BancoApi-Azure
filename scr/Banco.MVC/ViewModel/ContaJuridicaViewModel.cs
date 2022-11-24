using System.ComponentModel.DataAnnotations;

namespace Banco.MVC.ViewModel
{
    public class ContaJuridicaViewModel {

        [Key]
        public Guid Id { get; set; }


        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "14 Numeros obrigatorios")]
        [Range(0, 99999999999999, ErrorMessage = "Apenas numeros.")]
        public string CNPJ { get; set; }

        [Display(Name = "ChaveJ")]
        [StringLength(6, ErrorMessage = "6 Numeros obrigatorios")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0, int.MaxValue, ErrorMessage = "Apenas numeros.")]
        public string ChaveJ { get; set; }

        [Display(Name = "Usuario")]
        [StringLength(35, ErrorMessage = "35 Numeros obrigatorios")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,35}$",ErrorMessage = "Caracteres não incluso.")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Usuario { get; set; }

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
