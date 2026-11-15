using Domain;

namespace Application;

public interface ICategoriaRepository
{
    Task<List<Categoria>> ListarAsync(CancellationToken cancellationToken);
}