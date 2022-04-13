using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika_3_task
{
    public class Group:Student
    {
        public Student[] students = new Student[0];
        public string GroupNo;


        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

    }
}
