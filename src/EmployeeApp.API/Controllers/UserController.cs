using EmployeeApp.Core.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeApp.API.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            if (true)
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }


        }

        [HttpPost("add")]
        public async Task<IActionResult> Add()
        {
            return Ok();
        }


        [HttpPut("edit/{id}")]
        public IActionResult Edit(int id)
        {
            return Ok();
        }
    }
}
