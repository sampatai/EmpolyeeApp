using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Configurations
{
    public static class ServiceConfiguration
    {
        public static void AddServices(this IServiceCollection services,
                                            IConfiguration configuration)
        {
            services.RegisterDependencies();
        }
    }
}
