using Business.Notificacoes;
using Business.Interfaces;
using Business.Services;
using Data.Context;
using Data.Repository;
using Banco.ApiCore.Extensions;

namespace Banco.ApiCore.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();

            services.AddScoped<IContaFisicaRepository, ContaFisicaRepository>();
            services.AddScoped<IContaFisicaService, ContaFisicaService>();

            services.AddScoped<IContaJuridicaRepository, ContaJuridicaRepository>();
            services.AddScoped<IContaJuridicaService, ContaJuridicaService>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IUser, AspNetUser>();

            return services;
        }
    }
}
