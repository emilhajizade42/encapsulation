using System;

namespace EncapsulationHomeTask.Modals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var stu1 = new Student(1,"Emil","Hajizade","CS");
            var tk_80 = new Group("tk-80",2);
            stu1.info();
            tk_80.info();
            Console.WriteLine(tk_80.maxStuCount);
            Console.WriteLine(tk_80.students.Length);
            tk_80.addStudent(stu1);
            tk_80.addStudent(stu1); 
            tk_80.addStudent(stu1); 
            tk_80.addStudent(stu1); 
            tk_80.addStudent(stu1);
            Console.WriteLine(tk_80.students.Length);
            tk_80.removeStudent();
            tk_80.removeStudent();
            tk_80.removeStudent();
            Console.WriteLine(tk_80.students.Length);
        }
    }
}
