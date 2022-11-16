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
            conta.CNPJ = conta.CNPJ.Replace(".", "");

            conta.CNPJ = conta.CNPJ.Replace("/", "");

            conta.CNPJ = conta.CNPJ.Replace("-", "");


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
    }
}

