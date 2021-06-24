using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ChetuCoreWebApi.Services.v1;
using ChetuCoreWebApi.Model;

namespace ChetuCoreWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private IEmployee employee;
        public EmployeesController(IEmployee _employee)
        {
            employee = _employee;
        }

        [HttpGet]
        public IActionResult get()
        {
            return Ok(employee.GetEmployees());
        }


        [HttpPost]
        public IActionResult post(Employee emp)
        {
            employee.CreateEmployee(emp);
            return Ok("Employee Created Successfully.");
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            employee.DeleteEmployee(id);
            return Ok("Employee Deleted Successfully");
        }







    }
}