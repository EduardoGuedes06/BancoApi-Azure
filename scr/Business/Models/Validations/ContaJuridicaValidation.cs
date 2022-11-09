using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Validations
{
    public class ContaJuridicaValidation : AbstractValidator<ContaJuridica>
    {
        public ContaJuridicaValidation() 
        {
            RuleFor(c => c.CNPJ)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(14).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.ChaveJ)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(6).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.Usuario)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(35).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.Senha8dig)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(8).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

            RuleFor(c => c.Senha6dig)
                 .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                 .Length(6).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

        }
    }
}

