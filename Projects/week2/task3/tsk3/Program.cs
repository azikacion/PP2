using System;
using System.IO;

namespace Task3
{
    class Program
    {

        public static void Space(int level)//function to print spaces depending on deepness of path
        {
            for (int i = 0; i < level; i++)
            {
                Console.Write("   ");
            }
        }
        public static void ShowPath(DirectoryInfo dir, int level)//func to show path 
        {
            foreach (FileInfo f in dir.GetFiles())//foreach to write files' names and get their lvl
            {
                Space(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories())//foreach to write directories and get their lvl
            {
                Space(level);
                Console.WriteLine(d.Name);
                ShowPath(d, level + 1);
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo("/Users/ainagul/Projects");//path to a directory
            ShowPath(dir, 0);
            Console.ReadKey();
        }
    }
}