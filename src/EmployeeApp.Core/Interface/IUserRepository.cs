using EmployeeApp.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Core.Interface
{
    public interface IUserRepository : IRepository<User>
    {
    }
}
