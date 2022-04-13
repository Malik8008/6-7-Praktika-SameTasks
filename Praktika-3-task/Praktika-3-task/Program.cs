using System;

namespace Praktika_3_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Fullname = "Malik Seferov";
            Student student1 = new Student();
            student1.Fullname = "Polad Seferov";

            Group group = new Group();
            group.AddStudent(student);
            group.AddStudent(student1);

            foreach (var item in group.students)
            {
                Console.WriteLine(item.Fullname);
            }
        }
    }
}
