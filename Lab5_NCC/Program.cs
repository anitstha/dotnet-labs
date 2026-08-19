using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_NCC
{
    // Base class
    class Employee
    {
        public void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    // 1. Single Inheritance
    class Developer : Employee
    {
        public void Code()
        {
            Console.WriteLine("Developer is coding");
        }
    }

    // 2. Multilevel Inheritance
    class SeniorDeveloper : Developer
    {
        public void LeadTeam()
        {
            Console.WriteLine("Senior Developer is leading the team");
        }
    }

    // 3. Hierarchical Inheritance
    class Manager : Employee
    {
        public void Manage()
        {
            Console.WriteLine("Manager is managing the team");
        }
    }

    // Interfaces for Multiple Inheritance
    interface IProgrammer
    {
        void Program();
    }

    interface IResearcher
    {
        void Research();
    }

    // 4. Multiple Inheritance using Interfaces
    class Intern : IProgrammer, IResearcher
    {
        public void Program()
        {
            Console.WriteLine("Intern is programming");
        }

        public void Research()
        {
            Console.WriteLine("Intern is doing research");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance
            Console.WriteLine("Single Inheritance:");

            Developer developer = new Developer();

            developer.Work();
            developer.Code();


            // Multilevel Inheritance
            Console.WriteLine("\nMultilevel Inheritance:");

            SeniorDeveloper seniorDeveloper = new SeniorDeveloper();

            seniorDeveloper.Work();
            seniorDeveloper.Code();
            seniorDeveloper.LeadTeam();


            // Hierarchical Inheritance
            Console.WriteLine("\nHierarchical Inheritance:");

            Manager manager = new Manager();

            manager.Work();
            manager.Manage();


            // Multiple Inheritance
            Console.WriteLine("\nMultiple Inheritance:");

            Intern intern = new Intern();

            intern.Program();
            intern.Research();
        }
    }
}