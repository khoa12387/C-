using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double income = 50000; // Giả sử thu nhập là 50,000
            //TaxCalculator taxCalculator = new TaxCalculator();
            //// Tính thuế ở Mỹ
            //ITaxCalculator usaTax = new USATaxCalculator();
            //double usaTaxAmount = taxCalculator.CalculateTax(usaTax, income);
            //Console.WriteLine($"USA Tax on {income} is: {usaTaxAmount}");
            //// Tính thuế ở Anh
            //ITaxCalculator ukTax = new UKTaxCalculator();
            //double ukTaxAmount = taxCalculator.CalculateTax(ukTax, income);
            //Console.WriteLine($"UK Tax on {income} is: {ukTaxAmount}");
            //// Tính thuế ở Ấn Độ
            //ITaxCalculator indiaTax = new IndiaTaxCalculator();
            //double indiaTaxAmount = taxCalculator.CalculateTax(indiaTax, income);
            //Console.WriteLine($"India Tax on {income} is: {indiaTaxAmount}");



            //Employee employee = new Employee("Khoa", 5000);
            //// Tính lương
            //SalaryCalculator salaryCalculator = new SalaryCalculator();
            //double calculatedSalary = salaryCalculator.CalculateSalary(employee);
            //Console.WriteLine($"Calculated Salary: {calculatedSalary}");
            //// Tạo báo cáo
            //ReportGenerator reportGenerator = new ReportGenerator();
            //reportGenerator.GenerateReport(employee);



            // Tạo đối tượng cho chim biết bay
            //FlyingBird sparrow = new FlyingBird();
            //sparrow.Display();
            //sparrow.Fly();
            //Console.WriteLine();
            //// Tạo đối tượng cho chim cánh cụt
            //NonFlyingBird penguin = new Penguin();
            //penguin.Display();


            //Human human = new Human();
            //human.Work();
            //human.Eat();
            //Console.WriteLine();
            //// Tạo đối tượng Robot
            //Robot robot = new Robot();
            //robot.Work();


            // Tạo đối tượng LightBulb và Fan
            ISwitchable lightBulb = new LightBulb();
            ISwitchable fan = new Fan();

            // Tạo đối tượng Switch để điều khiển LightBulb
            Switch lightSwitch = new Switch(lightBulb);
            lightSwitch.Operate(true);  // Bật bóng đèn
            lightSwitch.Operate(false); // Tắt bóng đèn

            Console.WriteLine();

            // Tạo đối tượng Switch để điều khiển Fan
            Switch fanSwitch = new Switch(fan);
            fanSwitch.Operate(true);  // Bật quạt
            fanSwitch.Operate(false); // Tắt quạt
        }
    }
}
