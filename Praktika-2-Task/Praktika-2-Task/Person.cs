using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2_Task
{
    public class Person
    {
        private int _age;
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;  
            Age = age;
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value>0)
                {
                    _age = value;
                }
            }
        }
    }
}
