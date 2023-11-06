using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
