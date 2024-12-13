
using DataInfruStructure.DbContextFolder;
using Domain.IRepository;
using Microsoft.EntityFrameworkCore;

namespace DataInfruStructure.Repository;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    #region Ctor

    private readonly AppDbContext _DbContext;

    public GenericRepository(AppDbContext dbContext)
    {
        _DbContext = dbContext;
    }

    #endregion
    public async Task<TEntity> Get(int id)
    {
        return await _DbContext.Set<TEntity>().FindAsync(id) ?? throw new Exception();
    }


    public async Task<IQueryable<TEntity>> GetAll()
    {
        return _DbContext.Set<TEntity>().AsQueryable().AsNoTracking();
    }


    public async Task CreateAsync(TEntity entity)
    {
        await _DbContext.Set<TEntity>().AddAsync(entity);
        await _DbContext.SaveChangesAsync();
    }




    public async Task UpdateAsync(TEntity entity)
    {
        _DbContext.Set<TEntity>().Update(entity);
        await _DbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _DbContext.Set<TEntity>().Remove(entity);
        await _DbContext.SaveChangesAsync();
    }
}
