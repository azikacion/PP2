using System;

namespace DanaT3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = (Console.ReadLine()).Split();
            int[] arr = new int[n];
            for (int i=0; i<n; i++)
            {
                arr[i] = int.Parse(s[i]);
            }
            for (int i=0; i<n; i++)
            {
                Console.Write(arr[i] + " " + arr[i] + " ");
            }
        }
    }
}
