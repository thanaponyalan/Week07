﻿using System;

namespace Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Person();
            t.SayHi();
            Console.ReadKey();
        }
    }

    class Person
    {
        public virtual void SayHi()
        {
            Console.WriteLine("Hi I'm a person");
        }
    }

    class Student : Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi I'm a student");
        }
    }

    class Teacher : Person
    {
        public override void SayHi()
        {
            Console.WriteLine("Hi I'm a teacher");
        }
    }

    class Professor : Teacher
    {
        public new void SayHi()
        {
            Console.WriteLine("Hi I'm a professor");
        }
    }

}
