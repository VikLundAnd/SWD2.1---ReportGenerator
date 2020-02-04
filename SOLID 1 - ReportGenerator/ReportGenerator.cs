using System;
using System.Collections.Generic;

namespace ReportGenerator
{
    class ReportGenerator
    {
        protected List<Employee> generateList(EmployeeDB _employeeDB)
        {
            var employees = new List<Employee>();
            Employee employee;

            _employeeDB.Reset();

            // Get all employees
            while ((employee = _employeeDB.GetNextEmployee()) != null)
            {
                employees.Add(employee);
            }
            return employees;
        }
    }

    class ReportGenerator_salaryfirst : ReportGenerator
    {
        
        public  void CompileReport(EmployeeDB _employeeDB)
        {
            var employees = base.generateList(_employeeDB);

            Console.WriteLine("Salary-first report");
            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("------------------");
            }
        }
    }

    class ReportGenerator_namefirst : ReportGenerator
    {
        public void CompileReport(EmployeeDB _employeeDB)
        {
            var employees = base.generateList(_employeeDB);

            Console.WriteLine("Name-first report");
            foreach (var e in employees)
            {
                Console.WriteLine("------------------");
                Console.WriteLine("Name: {0}", e.Name);
                Console.WriteLine("Salary: {0}", e.Salary);
                Console.WriteLine("------------------");
            }
        }
    }
}