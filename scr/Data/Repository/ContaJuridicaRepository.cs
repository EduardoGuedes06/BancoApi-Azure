using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class ContaJuridicaRepository : Repository<ContaJuridica>, IContaJuridicaRepository
    {
        public ContaJuridicaRepository(MeuDbContext context) : base(context)
        {

        }
    }
}