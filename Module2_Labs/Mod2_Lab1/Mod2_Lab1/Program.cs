using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Employee Object with name Anuradha and salary 2000 called employee1
            var employee1 = new Employee("Anuradha", 2000);
            // Instantiates TechnicalEmployee Object with name Keerthana called employee2
            var employee2 = new TechnicalEmployee("Keerthana");
            // Instantiates BusinessEmployee Object with name Sangeetha called employee3
            var employee3 = new BusinessEmployee("Sangeetha");


            // Output to the console window
            Console.WriteLine(employee1.employeeStatus() + "..." + employee2.employeeStatus() + "..." + employee3.employeeStatus());
        }
    }
}
