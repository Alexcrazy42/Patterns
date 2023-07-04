
using Builder;

List<Employee> employees = new List<Employee>()
{
    new Employee { Name  = "Ivan", Salary = 100},
    new Employee { Name  = "Boris", Salary = 500},
    new Employee { Name  = "Alex", Salary = 200}

};

var builder = new EmployeeReportBuilder(employees);

var director = new EmployeeReportDirector(builder);

director.Build();

var report = builder.GetReport();

Console.WriteLine(report);
