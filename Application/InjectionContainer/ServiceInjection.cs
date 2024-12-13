using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace Application.InjectionContainer;

public static class ServiceInjection
{

    public static IServiceCollection Configuration( this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());



        return services;
    }
}
