using System;

namespace DanaT2
{
    class MainClass
    {
        class Student
        {
            public string Name;
            public string ID;
            public int year;

            public Student(string Name, string ID)
            {
                this.Name = Name;
                this.ID = ID;
            }

            public void Cout()
            {
                Console.WriteLine("Student's name - " + Name + Environment.NewLine + "Student's ID - " + ID + Environment.NewLine + "Year increased = " + ++year);
            }
        }
        public static void Main(string[] args)
        {
            Student Dana = new Student("Dana Toreshova", "18BD000000");
            Dana.year = 1;
            Dana.Cout();
        }
    }
}
