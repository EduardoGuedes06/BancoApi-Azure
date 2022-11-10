using Business.Interfaces;
using Business.Models;
using System.Xml.Linq;


namespace Business.Services
{
    public class ContaJuridicaService : BaseService, IContaJuridicaService
    {

        private readonly IContaJuridicaRepository _contaJuridicaRepository;
        public ContaJuridicaService(IContaJuridicaRepository contaJuridicaRepository, INotificador notificador) : base(notificador)
        {
            _contaJuridicaRepository = contaJuridicaRepository;
        }

        public async Task<bool> Adicionar(ContaJuridica conta)
        {
            if (_contaJuridicaRepository.Buscar(c => c.CNPJ == conta.CNPJ).Result.Any())
            {
                Notificar("CNPJ já Existente.");
                return false;
            }

            if (_contaJuridicaRepository.Buscar(c => c.Usuario == conta.Usuario).Result.Any())
            {
                Notificar("Usuario já Cadastrado.");
                return false;
            }

            conta.CNPJ = conta.CNPJ.Replace(".", "");

            conta.CNPJ = conta.CNPJ.Replace("/", "");

            conta.CNPJ = conta.CNPJ.Replace("-", "");

            await _contaJuridicaRepository.Adicionar(conta);
            return true;
        }

        public async Task Atualizar(ContaJuridica conta)
        {
            await _contaJuridicaRepository.Atualizar(conta);
        }

        public void Dispose()
        {
            _contaJuridicaRepository?.Dispose();
        }

        public async Task Remover(Guid id)
        {
            await _contaJuridicaRepository.Remover(id);
        }

        public async Task<bool> Verificar(ContaJuridica conta)
        {
            conta.CNPJ = conta.CNPJ.Replace(".", "");

            conta.CNPJ = conta.CNPJ.Replace("/", "");

            conta.CNPJ = conta.CNPJ.Replace("-", "");

            if (_contaJuridicaRepository.Buscar(c => c.CNPJ == conta.CNPJ).Result.Any())
            {
                if (_contaJuridicaRepository.Buscar(c => c.ChaveJ == conta.ChaveJ).Result.Any())
                {
                    if (_contaJuridicaRepository.Buscar(c => c.Usuario == conta.Usuario).Result.Any())
                    {

                        if (_contaJuridicaRepository.Buscar(c => c.Senha8dig == conta.Senha8dig).Result.Any())
                        {

                            if (_contaJuridicaRepository.Buscar(c => c.Senha6dig == conta.Senha6dig).Result.Any())
                            {

                                return true;
                            }
                            else { Notificar("Senha de 6 digitos Invalida."); }
                        }
                        else { Notificar("Senha de 8 digitos Invalida."); }
                    }
                    else { Notificar("Usuario Invalido."); }
                }
                else { Notificar("Chave Juridica Invalida."); }
            }
            else { Notificar("CNPJ Invalido."); }
            return false;
        }
    }
}

