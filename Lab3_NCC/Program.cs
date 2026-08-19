using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_NCC
{
    public class Program
    {
        //C# program to reverse element of an array
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elemenets: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Original Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");


            }
            //Reverse the array
            Array.Reverse(arr);

            Console.WriteLine("\nReversed Array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}
