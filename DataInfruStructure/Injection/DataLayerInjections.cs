

using DataInfruStructure.DbContextFolder;
using DataInfruStructure.Repository;
using DataInfruStructure.Repository.Category;
using Domain.IRepository;
using Domain.IRepository.ICategory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataInfruStructure.Injection;

public static class DataLayerInjections
{

    public static IServiceCollection DataConfiguration(this IServiceCollection services, IConfiguration conf)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));


        services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conf.GetConnectionString("AppDbContextConnectionString")));

        return services;
    }


}
