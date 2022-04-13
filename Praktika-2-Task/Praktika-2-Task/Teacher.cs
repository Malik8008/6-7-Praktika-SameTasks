using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_2_Task
{
    public class Teacher : Person
    {
        public int ID { get; }
        private int _experience;
        public static int Count = 0;

        public int Experience
        {
            get
            {
                return _experience;
            }
            set
            {
                if (value>= 1 && value<=80)
                {
                    _experience = value;
                }
            }
        }

        public Teacher(int experience,string name,string surname,int age):base(name,surname,age)
        {          
            Count++;
            ID = Count;
            Experience = experience;
        }
        public  void ShowInfo()
        {
            Console.WriteLine($"ID:{ID}  ||Name:{Name}  ||Surname:{Surname}  ||Age:{Age}  ||Experience:{Experience}");
        }
    }
}
