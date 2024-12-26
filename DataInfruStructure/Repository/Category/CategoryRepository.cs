using DataInfruStructure.DbContextFolder;
using Domain.IRepository.ICategory;

namespace DataInfruStructure.Repository.Category;

public class CategoryRepository : GenericRepository<Domain.Entities.Category>, ICategoryRepository
{


    public CategoryRepository(AppDbContext dbContext) : base(dbContext)
    {

    }



}
 