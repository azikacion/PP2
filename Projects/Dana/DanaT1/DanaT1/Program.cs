using System;
using System.IO;
using System.Collections.Generic;

namespace DanaT1
{
    class dana
    {
        public static bool Prm(int n)
        {
            for (int i = 2; i<=Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] r = (Console.ReadLine()).Split();
            int[] ar = new int[n];
            //int n = 5;
            //int a[n];
            for (int i = 0; i<n; i++)
            {
                ar[i] = int.Parse(r[i]);
            }
            for (int i=0; i<n; i++)
            {
                if(Prm(ar[i]) == true && ar[i] != 1)
                {
                    Console.Write(ar[i] + " ");
                }
            }
        }
    }
}
