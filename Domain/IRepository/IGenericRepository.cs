
namespace Domain.IRepository;

public interface IGenericRepository<TEntity> where TEntity : class
{

    Task<TEntity> Get(int id);
    Task<IQueryable<TEntity>> GetAll();
    Task CreateAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);

}
