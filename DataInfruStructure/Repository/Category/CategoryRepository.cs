using DataInfruStructure.DbContextFolder;
using Domain.Entities;
using Domain.IRepository.ICategory;

namespace DataInfruStructure.Repository.Category;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{


    public CategoryRepository(AppDbContext dbContext) : base(dbContext)
    {

    }



}
