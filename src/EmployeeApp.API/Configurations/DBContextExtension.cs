using EmployeeApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeApp.API.Configurations
{
    public static class DBContextExtension
	{
		public static void AddDbContext(this IServiceCollection services, IConfiguration configuration)
		{
			string dbConnection = configuration.GetConnectionString("SQLConnection");

			services.AddDbContext<EmployeeAppDBContext>(options => options
															.UseLazyLoadingProxies()
															.UseSqlServer(dbConnection));
		}
	}
}
