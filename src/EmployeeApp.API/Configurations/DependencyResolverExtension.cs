using EmployeeApp.BusinessLayer.Services.Users;
using EmployeeApp.Core.Interface;
using EmployeeApp.DataAccess;
using EmployeeApp.DataAccess.Repositories.Users;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Configurations
{
    public static class DependencyResolverExtension
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
