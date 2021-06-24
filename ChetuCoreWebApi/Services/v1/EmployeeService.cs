using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChetuCoreWebApi.Model;

namespace ChetuCoreWebApi.Services.v1
{
    public class EmployeeService : IEmployee
    {
        private EmployeeContext context;

        public EmployeeService()
        {
            context = new EmployeeContext();
        }

        public Employee CreateEmployee(Employee emp)
        {
            context.Employees.Add(emp);
            context.SaveChanges();
            return emp;
        }

        public Employee DeleteEmployee(int id)
        {
            var emp = context.Employees.SingleOrDefault(e => e.Id == id);
            if (emp!=null)
            {
               
               context.Employees.Remove(emp);
                context.SaveChanges();
            }
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return context.Employees.ToList();
        }
    }
}
