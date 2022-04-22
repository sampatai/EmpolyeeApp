
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using EmployeeApp.Core.Entities.Users;
using EmployeeApp.Core.Interface;
using EmployeeApp.DataAccess.Repositories.Common;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp.DataAccess.Repositories.Users
{
	public class UserRepository : Repository<User>, IUserRepository
	{
		private readonly EmployeeAppDBContext  _employeeAppDBContext;
		public UserRepository(EmployeeAppDBContext dbContext) : base(dbContext)
		{
			_employeeAppDBContext = dbContext;
		}
			
	}
}
