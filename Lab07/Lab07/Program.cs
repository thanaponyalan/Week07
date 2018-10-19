using System;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            TraineeStudent ts = new TraineeStudent("Thanapon",300);
            Console.WriteLine(ts.getSalary);
            Console.WriteLine(ts.getStudentID);
            Console.ReadLine();
        }
    }
    class TraineeStudent
    {
        private string StudentID;
        private int salary;

        public TraineeStudent(string id,int sal)
        {
            this.StudentID = id;
            if (sal >= 300 && sal <= 450)
                this.salary = sal;
            else
                throw (new Exception("Error! invalid salary"));
        }

        public string getStudentID
        {
            get
            {
                return StudentID;
            }
        }

        public int getSalary
        {
            get
            {
                return salary;
            }
        }
    }

}
