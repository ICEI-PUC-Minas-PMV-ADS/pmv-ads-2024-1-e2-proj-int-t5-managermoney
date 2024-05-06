using Microsoft.EntityFrameworkCore;

namespace ManagerMoney.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Usuario> Usuarios { get; set; }

  

        public DbSet<Cadastroveiculo> CadastroVeiculos { get; set; }

    }
}

