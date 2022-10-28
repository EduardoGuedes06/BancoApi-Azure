using AutoMapper;
using Banco.ApiCore.ViewModel;
using Business.Models;

namespace Banco.ApiCore.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ContaFisicaViewModel, ContaFisica > ().ReverseMap();
            CreateMap<ContaJuridicaViewModel, ContaJuridica >().ReverseMap();

        }
    }
}
