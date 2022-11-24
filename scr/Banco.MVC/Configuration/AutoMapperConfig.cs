using AutoMapper;
using Banco.MVC.ViewModel;
using Business.Models;

namespace Banco.MVC.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ContaFisicaViewModel, ContaFisica >().ReverseMap();
            CreateMap<ContaJuridicaViewModel, ContaJuridica >().ReverseMap();

        }
    }
}
