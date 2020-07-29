
using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class EnderecosAppService : AppServiceBase<EnderecosModel>, IEnderecosAppService
    {
        private readonly IEnderecosService _serviceBase;

        public EnderecosAppService(IEnderecosService serviceBase) : base(serviceBase)
        {
            _serviceBase = serviceBase;
        }

    }
}
