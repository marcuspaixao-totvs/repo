using Microsoft.Extensions.DependencyInjection;
using Parking.Domain;

namespace Parking.Infra
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddDomain();
            services.AddTransient<IParkingReadRepository, ParkingReadRepository>();

            return services;
        }
    }
}

