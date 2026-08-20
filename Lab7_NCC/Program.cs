using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_NCC
{
    // 7. C# program how virtual method are used in polymorphism

    class Person
    {
        public void Walk()
        {
            Console.WriteLine("Person is walking");
        }
    }

    class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("Student is studying");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Walk();
            student.Study();
        }
    }
}
