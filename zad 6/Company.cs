using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_6
{
    class Company
    {
        List<Employee> employees;
        public Company()
        {
            employees = new List<Employee>();
        }
        internal void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        internal void SearchEmployee(string name)
        {
            foreach (Employee employee in employees)
            {
                if (employee.Name == name)
                {
                    Console.WriteLine("Employee found: " + employee.Name + " " + employee.Salary);
                    return;
                }
            }
            Console.WriteLine("Employee not found");
        }
    }
}
