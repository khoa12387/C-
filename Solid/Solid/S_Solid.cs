using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
    }

    public class SalaryCalculator
    {
        public double CalculateSalary(Employee employee)
        {
            // Code tính lương
            Console.WriteLine($"Calculating salary for {employee.Name}");
            return employee.Salary;
        }
    }

    public class ReportGenerator
    {
        public void GenerateReport(Employee employee)
        {
            // Giả lập tạo báo cáo cho nhân viên
            Console.WriteLine($"Generating report for {employee.Name}");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Salary: {employee.Salary}");
        }
    }

}
