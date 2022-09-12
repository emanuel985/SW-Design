using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportGenerator.classes;

namespace ReportGenerator.classes
{
    class NameFirstReportPrinter : ReportPrinter
    {
        public void PrintReport(List<Employee> employeeList)
        {
            Console.WriteLine("Name-first report");
        foreach (var e in employeeList)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Name: {0}", e.Name);
            Console.WriteLine("Salary: {0}", e.Salary);
            Console.WriteLine("------------------");
        }
        }
        

    }
}
