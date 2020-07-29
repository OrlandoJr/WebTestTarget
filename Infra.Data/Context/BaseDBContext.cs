using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infra.Data.Context
{
    public class BaseDBContext : DbContext
    {
        public BaseDBContext(DbContextOptions<BaseDBContext> options) : base(options)
        {

        }

        public DbSet<ClientesModel> Clientes { get; set; }
        public DbSet<EnderecosModel> Enderecos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }


    }
}
