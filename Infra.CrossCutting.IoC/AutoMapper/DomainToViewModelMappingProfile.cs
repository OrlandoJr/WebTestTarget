using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Infra.CrossCutting.IoC
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ClientesModel, ClientesViewModel>();
            CreateMap<ClientesModel, ClientesPostViewModel>();
            CreateMap<ClientesModel, ClientesPutViewModel>();

            CreateMap<EnderecosModel, EnderecosViewModel>();
            CreateMap<EnderecosModel, EnderecosPostViewModel>();
            CreateMap<EnderecosModel, EnderecosPutViewModel>();
        }
    }
}
