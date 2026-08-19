using System;


namespace Lab4_NCC
{ //C# program how Name of Student are stored and retrieved using indexer. 
    public class Program
    {
        static void Main(string[] args)
        {
            Students s = new Students();

            //store names using indexer
            s[0] = "Anit";
            s[1] = "Sudip";
            s[2] = "Bhim";
            s[3] = "Pratik";
            s[4] = "Ram";

            //Retrive names using indexer
            Console.WriteLine("Student Names: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Student " + (i + 1) + ": " + s[i]);
            }

        }
    }
    public class Students
    {
        private string[] names = new string[5];

        //Indexer
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
    }
}
