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

        public virtual async Task Adicionar(ContaFisica contaFisica)
        {


            DbSet.Add(contaFisica);
            await SaveChanges();
        }


    }
}
