using System;
using Business.Models;
namespace Business.Interfaces
{
    public interface IContaJuridicaService : IDisposable
    {

        Task<bool> Adicionar(ContaJuridica conta);
        Task<bool> Verificar(ContaJuridica conta);
        Task Atualizar(ContaJuridica conta);
        Task Remover(Guid id);
    }
}

