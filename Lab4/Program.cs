using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        private static void Main(string[] args)
        {

            Employee employee = new Employee
            {
                Name = "Kirsi Kernel",
                Profession = "Teacher",
                Salary = 2000
            };
            Console.WriteLine(employee.ToString());

            Boss boss = new Boss
            {
                Name = "Kalle Koivisto",
                Profession = "Boss",
                Salary = 5000,
                Car = "Ferrari",
                Bonus = 2500
            };

            Console.WriteLine(boss.ToString());

        }
    }

}
