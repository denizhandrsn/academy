using Microsoft.Extensions.DependencyInjection;

namespace Business.DependencyResolvers
{
    public static class BusinessServiceRegistiration
    {
        public static IServiceCollection AddBusinessService(this IServiceCollection services)
        {
            services.AddAutoMapper(assemblies: AppDomain.CurrentDomain.GetAssemblies());




            return services;
        }
    }
}
