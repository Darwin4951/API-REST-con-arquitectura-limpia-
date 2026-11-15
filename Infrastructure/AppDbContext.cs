using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options)
    : DbContext(options)
{
    public DbSet<Receta> Recetas => Set<Receta>();
    public DbSet<Categoria> Categorias => Set<Categoria>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>().HasData(
            new Categoria { Id = 1, Nombre = "Entradas" },
            new Categoria { Id = 2, Nombre = "Platos fuertes" },
            new Categoria { Id = 3, Nombre = "Postres" }
        );
    }
}