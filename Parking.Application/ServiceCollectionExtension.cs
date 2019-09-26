using Microsoft.Extensions.DependencyInjection;
using Parking.Application.Interface;
using Parking.Application;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            
            services.AddTransient<IParkingAppService, ParkingAppService>();
            services.AddTransient<ICarAppService, CarAppService>();
            services.AddTransient<IRateAppService, RateAppService>();


            return services;
        }
    }
}

