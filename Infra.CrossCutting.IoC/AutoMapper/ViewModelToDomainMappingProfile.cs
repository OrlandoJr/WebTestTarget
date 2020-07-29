using Application.ViewModel;
using AutoMapper;
using Domain.Entities;

namespace Infra.CrossCutting.IoC
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ClientesViewModel, ClientesModel>();
            CreateMap<ClientesPostViewModel, ClientesModel>();
            CreateMap<ClientesPutViewModel, ClientesModel>();

            CreateMap<EnderecosViewModel, EnderecosModel>();
            CreateMap<EnderecosPostViewModel, EnderecosModel>();
            CreateMap<EnderecosPutViewModel, EnderecosModel>();
        }
    }
}