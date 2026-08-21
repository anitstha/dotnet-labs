using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18_EF_CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("========================================");
                Console.WriteLine("   CRUD Operations (Entity Framework)");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Create (Insert)");
                Console.WriteLine("2. Read (Select)");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");
                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: Insert(); break;
                    case 2: Select(); break;
                    case 3: Update(); break;
                    case 4: Delete(); break;
                    case 5: return;
                }
            }

        }

        static void Insert()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            using (var context = new StudentDbContext())
            {
                Student s = new Student
                {
                    Name = name,
                    Age = age

                };
                context.Students.Add(s);
                context.SaveChanges();
                Console.WriteLine("Record inserted successfully.");
            }
        }

        static void Select()
        {
            using (var context = new StudentDbContext())
            {
                var students = context.Students.ToList();
                Console.WriteLine("Id\tName\tAge");
                Console.WriteLine("-------------------");
                foreach (var s in students)
                {
                    Console.WriteLine(s.Id + "\t" + s.Name + "\t" + s.Age);
                }
            }
        }

        static void Update()
        {
            Select();
            Console.Write("Enter Id to update: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new StudentDbContext())
            {
                var student = context.Students.Find(id);
                if (student != null)
                {
                    Console.Write("Enter new Name: ");
                    student.Name = Console.ReadLine();
                    Console.Write("Enter new Age: ");
                    student.Age = int.Parse(Console.ReadLine());
                    context.SaveChanges();
                    Console.WriteLine("Record updated.");
                }
                else
                {
                    Console.WriteLine("Record not found.");
                }
            }
        }

        static void Delete()
        {
            Select();
            Console.Write("Enter Id to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (var context = new StudentDbContext())
            {
                var student = context.Students.Find(id);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                    Console.WriteLine("Record deleted.");
                }
                else
                {
                    Console.WriteLine("Record not found.");
                }
            }
        }

    }
}
