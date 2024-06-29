using Api_Mvc_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Mvc_Entity.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UsuarioModel>()
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<ProdutoModel>()
                .Property(b => b.Id)
                .ValueGeneratedOnAdd();
        }

        public DbSet<ProdutoModel> Produto { get; set; } = null;
        public DbSet<UsuarioModel> Usuario { get; set; } = null;
    }
}
