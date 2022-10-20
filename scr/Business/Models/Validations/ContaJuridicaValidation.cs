using System;
using FluentValidation;
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

            RuleFor(c => c.Senha6Dig)
                 .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                 .Length(6).WithMessage("O campo {PropertyName} precisa ter {MaxLength} caracteres");

        }
    }
}

