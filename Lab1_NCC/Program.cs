using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_NCC
{
    public class Program
    {
        //1. Write a C# program to add two digit using constructor

        //Main Function ... Entry Point of our project
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            //Create object to add two number
            AddNumbers _obj = new AddNumbers(a, b);
            Console.WriteLine("Sum of x and y is: " + _obj.Sum);

            Console.ReadKey();
        }
    }

    public class AddNumbers
    {
        public int Sum { get; set; }

        //Constructor tht adds two digits
        public AddNumbers(int x, int y)
        {
            Sum = x + y;
        }
    }
}
