using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assign_03_hierarchy
{
    interface IPrintable
    {
        void printDetails();
    }
    public class Employee : IPrintable
    {
        string Name, designation;
        protected double netSalary, grossSalary;

        protected Employee()
        {
            this.Name = "";
            this.designation = "";
            this.netSalary = 0.0;
            this.grossSalary = 0.0;
        }

        protected Employee(string name, string designation, double salary)
        {
            this.Name = name;
            this.designation = designation;
            this.netSalary = salary;
        }

        public virtual void CalculateSalary()
        { 
            Console.WriteLine("Calculating Salary"); //It will be overrided!
        }

        public void printDetails()
        {
            Console.WriteLine("\n---------Details of the Employee---------\n");
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Designation: {0}", this.designation);
            Console.WriteLine("Net Salary: {0}", this.netSalary);
            Console.WriteLine("Gross Salary: {0}\n", this.grossSalary);
        }
    }

    public class Manager : Employee
    {
        private double petrolAllowance, foodAllowance, otherAllowance;

        public Manager(string name, string designation, double salary) : base(name, designation, salary)
        {
            this.petrolAllowance = 0.08 * salary;
            this.foodAllowance = 0.13 * salary;
            this.otherAllowance = 0.03 * salary;
        }

        public override void CalculateSalary()//Overriding
        {
            grossSalary = petrolAllowance + foodAllowance + otherAllowance + netSalary;

        }
    }

    public class MarketingExecutive : Employee
    {
        double kilometerTravel, tourAllowance;
        double telephoneAllowance;

        public MarketingExecutive(string name, string designation, double salary, double kilometers) : base(name, designation, salary)
        {
            this.kilometerTravel = kilometers;
            tourAllowance = 5 * this.kilometerTravel;
            telephoneAllowance = 1000;
        }

        public override void CalculateSalary()
        {
            grossSalary = netSalary + kilometerTravel + tourAllowance + telephoneAllowance;
        }
    }
}
