using System;

namespace Task2
{
    //public enum Retake : int { retake, not };
    class Student {//Class with student's parameters
        public string Name;
        public string id;
        public int year;
        //public Retake rtk;
        public Student(string Name, string id)//Construct with using parameters
        {
            this.Name = Name;//Setting student's Name
            this.id = id;//Setting his ID
            //this.rtk = rtk;
        }
        public void Cout()//Override of student's info(parameters set in Class Student)
        {
            Console.WriteLine("Student's name: " + Name + Environment.NewLine + "Student's ID: " + id + Environment.NewLine + "Sudent's year increased: " + ++year);
        }

    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student Azik = new Student("Azik Sakenov", "18BD110750");
            Azik.year = 0;
            Azik.Cout();
        }
    }
}
