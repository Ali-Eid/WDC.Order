using Microsoft.Extensions.DependencyInjection;
using WDC.Orders.Infrastructure.Bases.RepositoryBase;

namespace WDC.Orders.Infrastructure;

public static class ModuleInfrastructureDependencies
{
    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

        return services;
    }
}

