using Application;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class CategoriaRepository(AppDbContext dbContext)
    : ICategoriaRepository
{
    public Task<List<Categoria>> ListarAsync(CancellationToken cancellationToken)
    {
        return dbContext.Categorias
            .AsNoTracking()
            .OrderBy(categoria => categoria.Id)
            .ToListAsync(cancellationToken);
    }
}