using System;
using System.Management.Instrumentation;
using System.IO;

namespace TESVII
{
    class MainClass
    {
        public static bool Plndrm(string s) { // функция для проверки на палиндромность
            for (int i = 0, j = s.Length - 1; i <=j; i++, j--) //цикл пробегается по слову с двух сторон, если 
                {       
                    if(s[i] != s[j])
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadLine();
            
                if (Plndrm(s) == true){
                Console.WriteLine("zbs");
            }
            else
            {
                Console.Write("fail");
            }
        }
    }
}
