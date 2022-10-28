using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Banco.ApiCore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    //MYSQL
        //    options.UseMySql("server=localhost;initial catalog=InterpriseStoreDb;uid=root;pwd=Root",
        //    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.0-mysql")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        //    //SQLSERVER
        //    //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        //}

    }
}