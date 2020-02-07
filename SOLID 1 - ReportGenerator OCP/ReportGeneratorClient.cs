using System;

namespace ReportGenerator
{
    internal class ReportGeneratorClient
    {
        private static void Main()
        {
            var db = new EmployeeDB();

            // Add some employees
            db.AddEmployee(new Employee("Anne", 3000, 18));
            db.AddEmployee(new Employee("Berit", 2000, 20));
            db.AddEmployee(new Employee("Christel", 1000, 24));


            // Create a default (name-first) report
            var reportGenerator = new ReportGenerator_namefirst();
            reportGenerator.CompileReport(db);

            Console.WriteLine("");
            Console.WriteLine("");
                
            // Create a salary-first report
            var reportGenerator2 = new ReportGenerator_salaryfirst();
            reportGenerator2.CompileReport(db);

            Console.WriteLine("");
            Console.WriteLine("");

            // Create a salary-first report
            var reportGenerator3 = new ReportGenerator_agefirst();
            reportGenerator3.CompileReport(db);
        }
    }
}