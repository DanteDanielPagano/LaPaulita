using AplicationLayerUseCaseProject.Interactors;
using ApplicationLayerProject.Ports.UseCases.CreateOrder;
using Microsoft.Extensions.DependencyInjection;

namespace AplicationLayerUseCaseProject
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateOrderInputPort, CreateOrderInteractor>();

            return services;
        }
    }
}
