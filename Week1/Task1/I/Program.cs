using System;
using System.Collections.Generic;

namespace I
{
    class Proga
    {
        public static bool F1(int n) //Boolean function to chec if number is prime
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)//Cycle to check if numbers devides by other numbers from 2 to its square root 
            {
                if (n % i == 0)//If number devides by others from to its square root without reminder its not prime
                    return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//Input of array's size
            int[] arr = new int[n];//Creating an array of integers
            string s = Console.ReadLine();//Input of string of numbers 
            string[] a = s.Split();//Spliting the input string
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(a[i]);//Parsing every number from string to int
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (F1(arr[i]) && arr[i] != 1)//Checking if boolean func returns true or false
                {
                    Console.Write(arr[i] + " ");//Output of "true" numbers
                }
            }
        }
    }
}
