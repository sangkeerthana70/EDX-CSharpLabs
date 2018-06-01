using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_Lab1
{
    public class Employee
    {

        // 3 private member variables: employeeName, employeeBaseSalary, and employeeId
        private string employeeName;
        private double employeeBaseSalary;
        private int employeeId;

        // Public properties
        public string Name
        {
            get
            {
                return employeeName;
            }

            set
            {
                employeeName = value;
            }
        }
        public double BaseSalary
        {
            get
            {
                return employeeBaseSalary;
            }

            set
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        // Creates a static member variable of type integer  called "employeeCount" and assigns value to 1
        private static int employeeCount = 1;



        // Constructor
        public Employee(String name, double baseSalary)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }


        public double getBaseSalary()
        {
            return this.BaseSalary;//employee's base salary
        }

        //this method returns the employee's name
        public String getName()
        {
            return this.Name;
        }

        public int getEmployeeID()// this method will return the employee's ID when they are constructed
        {
            return this.ID;
        }

        public String toString()//this method will return a String representation of the employee that is a combination of their id followed by their name. 
        {
            return this.ID + " " + this.Name;
        }

        // This method returns the employee's ID and Name and confirms that the employee is in the system
        public virtual String employeeStatus()//Should return a String representation of that Employee's current status and state that they are in the company system
        {
            Console.WriteLine("Employee Status");
            return toString() + " is in the company's system";
        }
    };

}
