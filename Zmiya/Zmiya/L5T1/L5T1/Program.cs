using System;
using System.Threading;
namespace L5T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for (int i=0; i<3; i++)
            {
                threads[i] = new Thread(Print);
                threads[i].Name = (i + 1).ToString();
                threads[i].Start();
            }
        }
        static void Print()
        {
            for (int i=0; i<3; i++)
            {
                Console.WriteLine("Current Thread: " + Thread.CurrentThread.Name);
            }
        }
    }
}
