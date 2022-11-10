using Business.Interfaces;
using Business.Models;

namespace Business.Services
{
    public class ContaFisicaService : BaseService, IContaFisicaService
    {
        private readonly IContaFisicaRepository _contaFisicaRepository;

        public ContaFisicaService(IContaFisicaRepository contaBancariaRepository, INotificador notificador) : base(notificador)
        {
            _contaFisicaRepository = contaBancariaRepository;
        }

        public async Task<bool> Adicionar(ContaFisica conta)
        {
            if (_contaFisicaRepository.Buscar(c => c.CPF == conta.CPF).Result.Any())
            {
                Notificar("CPF já Existente.");
                return false;
            }


            conta.CPF = conta.CPF.Replace(".", "");

            conta.CPF = conta.CPF.Replace("/", "");

            conta.CPF = conta.CPF.Replace("-", "");

      


            await _contaFisicaRepository.Adicionar(conta);
            return true;

        }


        public async Task Atualizar(ContaFisica conta)
        {

            await _contaFisicaRepository.Atualizar(conta);
        }

        public async Task Remover(Guid id)
        {

            await _contaFisicaRepository.Remover(id);
        }

        public void Dispose()
        {
            _contaFisicaRepository.Dispose();
        }

        public async Task<bool> Verificar(ContaFisica conta)
        {
            conta.CPF = conta.CPF.Replace(".", "");

            conta.CPF = conta.CPF.Replace("/", "");

            conta.CPF = conta.CPF.Replace("-", "");

            if (_contaFisicaRepository.Buscar(c => c.CPF == conta.CPF).Result.Any())
            {
                if (_contaFisicaRepository.Buscar(c => c.Agencia == conta.Agencia).Result.Any())
                {
                    if (_contaFisicaRepository.Buscar(c => c.ContaCorrente == conta.ContaCorrente).Result.Any())
                    {
                        
                        if (_contaFisicaRepository.Buscar(c => c.Senha8dig == conta.Senha8dig).Result.Any())
                        {
                           
                            if (_contaFisicaRepository.Buscar(c => c.Senha6dig == conta.Senha6dig).Result.Any())
                            {
                                
                                return true;
                            }else { Notificar("Senha de 6 digitos Invalida."); }
                        }else { Notificar("Senha de 8 digitos Invalida."); }
                    }else { Notificar("Conta Corrente Invalida."); }
                } else { Notificar("Agencia Invalida."); }
            }
            else { Notificar("CPF Invalido.");}
            return false;
        }

    }
}
