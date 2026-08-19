using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_NCC
{
    internal class Program
    {
        //2. Write a C# program to display student Id and Name using automatic properties
        static void Main(string[] args)
        {
            Console.WriteLine("Enter student Id: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter student Name: ");
            string b = Console.ReadLine();

            Student _obj = new Student();
            _obj.StudentId = a;
            _obj.Name = b;

            Console.WriteLine("Student Id: " + _obj.StudentId + " " + "Student Name: " + _obj.Name);

            Console.ReadKey();
        }
    }

    public class Student
    {
        //automatic property
        public int StudentId { get; set; }
        public string Name { get; set; }


    }
}
