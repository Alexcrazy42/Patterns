using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EmployeeReportBuilder : IEmployeeReportBuilder
    {
        private EmployeeReport _employeeReport;

        private readonly IEnumerable<Employee> _employees;

        public EmployeeReportBuilder(IEnumerable<Employee> employees)
        {
            _employees = employees;
            _employeeReport = new EmployeeReport();
        }

        public void BuildHeader()
        {
            _employeeReport.Header =
                $"Employee report on date: {DateTime.Now}\n";
            _employeeReport.Header +=
                "\n---------------------------------------\n";
        }

        public void BuildBody()
        {
            _employeeReport.Body =
                String.Join(Environment.NewLine,
                            _employees.Select(e =>
                            $"Employee: {e.Name} \t\tSalary: {e.Salary}$"));
        }

        public void BuildFooter()
        {
            _employeeReport.Footer = "\n---------------------------------------";
            _employeeReport.Footer +=
                $"\nTotal employees: {_employees.Count()}, " +
                $"Total salary: {_employees.Sum(e => e.Salary)}";
        }

        public EmployeeReport GetReport()
        {
            EmployeeReport employeeReport = _employeeReport;
            _employeeReport = new();
            return employeeReport;
        }
    }
}
