using Business.Models;

namespace Business.Interfaces
{
    public interface IContaFisicaService : IDisposable
    {
        Task<bool> Adicionar(ContaFisica conta);
        Task Atualizar(ContaFisica conta);
        Task Remover(Guid id);
    }
}
