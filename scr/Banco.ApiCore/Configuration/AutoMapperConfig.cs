using AutoMapper;
using Banco.ApiCore.ViewModel;
using Business.Models;

namespace Banco.ApiCore.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ContaFisica, ContaFisicaViewModel>().ReverseMap();
            CreateMap<ContaJuridica, ContaJuridicaViewModel>().ReverseMap();

        }
    }
}
