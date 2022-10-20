using Business.Interfaces;
using Business.Models;
using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repository
{
    public class ContaFisicaRepository : Repository<ContaFisica>, IContaFisicaRepository
    {
        public ContaFisicaRepository(MeuDbContext context) : base(context)
        {

        }

    }
}
