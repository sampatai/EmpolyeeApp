using EmployeeApp.Core.Interface;
using EmployeeApp.DataAccess.Repositories.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeAppDBContext _employeeAppDBContext;
        private IUserRepository _userRepository;


        public UnitOfWork(EmployeeAppDBContext dbContext)
        {
            _employeeAppDBContext = dbContext;
        }


        public int Complete()
        {
            return _employeeAppDBContext.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _employeeAppDBContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _employeeAppDBContext.Dispose();
        }

        public IUserRepository Users => _userRepository ??= new UserRepository(_employeeAppDBContext);
    }
}
