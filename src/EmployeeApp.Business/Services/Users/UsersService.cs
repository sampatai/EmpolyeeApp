using System.Collections.Generic;
using System;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using EmployeeApp.Core.Interface;

namespace EmployeeApp.BusinessLayer.Services.Users
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;


        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }

    }

}
