using ChetuCoreWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChetuCoreWebApi.Services.v1
{
   public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee CreateEmployee(Employee emp);
        Employee DeleteEmployee(int id);

    }
}
