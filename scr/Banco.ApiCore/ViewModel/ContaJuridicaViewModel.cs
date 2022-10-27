﻿using System.ComponentModel.DataAnnotations;

namespace Banco.ApiCore.ViewModel
{
    public class ContaJuridicaViewModel {

        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]

        public string CNPJ { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ChaveJ { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string usuario { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha8dig { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Senha6dig { get; set; }
        public string? UsuarioLogin { get; set; }
        public DateTime? DataCriacao { get; set; }
    }
    
}
