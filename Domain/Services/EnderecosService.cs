using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class EnderecosService : ServiceBase<EnderecosModel>, IEnderecosService
    {
        private readonly IEnderecosRepository _repository;

        public EnderecosService(IEnderecosRepository repository) : base(repository)
        {
            _repository = repository;
        }


    }
}
