using Api_Mvc_Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Mvc_Entity.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<ProdutoModel> Produto { get; set; } = null;
        public DbSet<UsuarioModel> Usuario { get; set; } = null;
    }
}
