using System;
using System.IO;
using System.Collections.Generic;
namespace Task2
{
    class Program
    {
    public static bool Prm(int n)//functon to check if number is prime
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");//reading numbers from input file
            String s = sr.ReadToEnd();
            String[] arr = s.Split();//spliting input string
            int[] a = new int[arr.Length];
            sr.Close();//closing input file
            for (int i = 0; i < arr.Length; i++)
            {
                a[i] = Convert.ToInt32(arr[i]);//convering string to int
            }
            StreamWriter sw = new StreamWriter("output.txt");
            for (int i = 0; i < a.Length; i++)
            {
                if (Prm(a[i]) == true) sw.Write(a[i] + " ");//function to write number to output file if they are prime
            }
            sw.Close();
        }
    }
}
