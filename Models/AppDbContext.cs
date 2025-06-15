using parcial.Models;
using System.Data.Entity;

namespace Parcial.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
            { }
        public DbSet<Producto> Producto { get; set; } = null!;

    }
}