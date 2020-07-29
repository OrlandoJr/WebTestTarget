
using Application.Interfaces;
using Application.ViewModel;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class ClientesAppService : AppServiceBase<ClientesModel>, IClientesAppService
    {
        private readonly IClientesService _serviceBase;

        public ClientesAppService(IClientesService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }

    }
}
