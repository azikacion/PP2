using System;

namespace TASK2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //Setting size of an array
            int[ , ] r = new int[n, n]; //Creating array with n columns and n strings
            for (int i=0; i<n; i++) //Parameters for strings
            {
                for (int j=0; j<i+1; j++) //Parameters for columns
                {
                    Console.Write("[*]"); //Output of symbol
                }
                Console.WriteLine(); //Going to a new string
            }
        }
    }
}
