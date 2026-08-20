using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Lab17
{
    // 17. Write Console Application to perform CRUD Operation using Ado.Net in C#
    public class Program
    {
        static string connectionString = @"Data Source=.\SQLEXPRESS;Database=studentDB;Integrated Security=True;";
        static void Main(string[] args)
        {
            InsertRecord();
        }

        //insert
        static void InsertRecord()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DOB");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter MobileNo");
            string mobileno = Console.ReadLine();


            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tblStudent (Name, Age, DOB, Address, MobileNo) VALUES (@name, @age, @dob, @address, @mobileno)", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@mobileno", mobileno);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    Console.WriteLine("Record inserted successfully.");
                }
                else
                {
                    Console.WriteLine("Record inserted failed");
                }

                conn.Close();

            }
        }

        //update
        static void UpdateRecord()
        {
            Console.WriteLine("Enter Id to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter new Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter new Age: ");
            int age = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tblStudent SET Name=@name, Age=@age WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@id", id);
                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "Record updated" : "Record not found");
            }
        }

        //delete
        static void DeleteRecord()
        {
            Console.WriteLine("Enter Id to delete: ");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM tblStudent WHERE Id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();
                Console.WriteLine(rows > 0 ? "Record deleted" : "Record not found");
            }
        }

        //select
        static void SelectRecord()
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * FROM tblStudent", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("\nId\tName\tAge");
                Console.WriteLine("-----------------------------");
                    while(reader.Read())
                {
                    Console.WriteLine(reader["Id"] + "\t" + reader["Name"] + "\t" + reader["Age"]);
                }
            }

        }
    }
}