using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {
        private List<Employee> employees = new List<Employee> { new Employee { Name = "Ans", ID = 1, Gender = "Male", DateOfBirth = DateTime.Now },
                                                                new Employee { Name = "MUSI", ID = 2, Gender = "Male", DateOfBirth = DateTime.Now.AddYears(-10) }};
        public Employee GenEmployee(int id)
        {

            return employees.FirstOrDefault(x => x.ID == id);
        }
        public void saveEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}