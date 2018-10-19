using System;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student su = new Student();
            su.Name = "Student Name";
            su.ID = "12345678";
            su.GPA = 7.5f;
            Console.WriteLine("Student name : " + su.Name);
            Console.WriteLine("Student ID   : " + su.ID);
            Console.WriteLine("Student GPA  : " + su.GPA);
            Console.ReadLine();
        }
    }
    class Student
    {
        private string name;
        private string id;
        private float gpa;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public float GPA
        {
            get { return gpa; }
            set { gpa = value; }
        }
    }

}
