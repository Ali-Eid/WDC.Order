using Microsoft.Extensions.DependencyInjection;
using WDC.Orders.Service.OrderServices;

namespace WDC.Orders.Service;

public static class ModuleServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {

        services.AddTransient<IOrderService, OrderService>();

        return services;
    }
}