using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2_Task
{
    public class Student:Person
    {
        public int Id { get;}
        public static int Count = 0;

        public Student(string name, string surname,int age) : base(name, surname,age)
        {
            Count++;
            Id = Count;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"ID:{Id}  ||Name:{Name}  ||Surname:{Surname}  ||Age:{Age}");
        }
    }
}
