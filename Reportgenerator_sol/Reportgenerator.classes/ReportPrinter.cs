using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportGenerator.classes;

namespace ReportGenerator.classes
{
    internal interface ReportPrinter
    {
        void PrintReport(List<Employee> employeeList);
    }
    
}
