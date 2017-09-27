using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {



            
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 2000;
            Console.WriteLine(employee.ToString());

            Boss boss = new Boss();
            boss.Name = "Kalle Koivisto";
            boss.Profession = "Head of Firm";
            boss.Salary = 5000;
            boss.Car = "Ferrari";
            boss.Bonus = 2500;


            Console.WriteLine(boss.ToString());

            

        }
    }

}
