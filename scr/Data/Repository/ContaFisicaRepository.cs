using Business.Interfaces;
using Business.Models;
using Data.Context;


namespace Data.Repository
{
    public class ContaFisicaRepository : Repository<ContaFisica>, IContaFisicaRepository
    {
        public ContaFisicaRepository(MeuDbContext context) : base(context)
        {

        }

    }
}
