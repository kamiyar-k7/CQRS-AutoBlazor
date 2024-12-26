using Application.Services.CategoryType.Handler.Command;
using Application.Services.CategoryType.Handler.Query;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Application.InjectionContainer;

public static class ServiceInjection
{

    public static IServiceCollection ApplicationConfiguration(this IServiceCollection services)
    {

        #region Category

        services.AddMediatR(cfg =>
        {
            cfg.RegisterServicesFromAssembly(typeof(CreateCategoryHandler).Assembly); 
            cfg.RegisterServicesFromAssembly(typeof(DeleteCategoryHandler).Assembly);
            cfg.RegisterServicesFromAssembly(typeof(UpdateCategotyHandler).Assembly);
            cfg.RegisterServicesFromAssembly(typeof(GetAllCategoryHandler).Assembly);
            cfg.RegisterServicesFromAssembly(typeof(GetCategoryHandler).Assembly);
        });

        #endregion

        return services;
    }
}
