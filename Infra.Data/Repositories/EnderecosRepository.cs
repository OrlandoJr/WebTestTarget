using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infra.Data.Context;


namespace Infra.Data.Repositories
{
    public class EnderecosRepository : RepositoryBase<EnderecosModel>, IEnderecosRepository
    {
        public EnderecosRepository(BaseDBContext context) : base(context)
        {
        }

    }
}
