using System;

namespace Praktika_2_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int expe1;

            do
            {
                Console.WriteLine("Enter Teacher Age:");
                age=Convert.ToInt32(Console.ReadLine());
            } while (age<0);

            do
            {
                Console.WriteLine("Enter Teacher Experience:");
                expe1 = Convert.ToInt32(Console.ReadLine());
            } while (expe1<1 || expe1>80);

            Teacher teacher = new Teacher(expe1, "Zulfi", "Ilxasli", age);


            int age1;
            int age2;
            do
            {
                Console.WriteLine("Enter First Student Age:");
                age1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Student Age");
                age2=Convert.ToInt32(Console.ReadLine());
            } while (age1<0 && age2<0);


            
            Student student = new Student("Malik","Seferov",age1);
            Student student1 = new Student("Polad","Safarov",age2);
            Console.WriteLine("Teacher:");
            teacher.ShowInfo();
            Console.WriteLine("\n");
            Console.WriteLine("Students:");
            student.ShowInfo();
            student1.ShowInfo();

        }
    }
}
