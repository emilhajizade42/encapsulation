using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomeTask.Modals
{
    internal class Group
    {
        private string Name;
        private int MaxStuCount;
        private Student[] Students = {};
        public string  name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public int maxStuCount
        {
            get
            {
                return MaxStuCount;
            }
            set
            {
                MaxStuCount = value;
            }
        }
        public Student[] students
        {
            get
            {
                return Students;
            }
            set
            {
                Students = value;
            }
        }


        public void addStudent(Student obj)
        {
            if (Students.Length<maxStuCount )
            {
                Student[] temp = new Student[Students.Length + 1];
                for (int i = 0; i < Students.Length; i++)
                {
                    temp[i] = Students[i];
                }
                temp[Students.Length] = obj;
                Students = temp;
                return;
            }
            Console.WriteLine("Qrupda yer yoxdur");
        }
        public void removeStudent()
        {
            if (Students.Length > 0)
            {
                Student[] temp = new Student[Students.Length - 1];
                for (int i = 0; i < Students.Length-1; i++)
                {
                    temp[i] = Students[i];
                }
                
                Students = temp;
                return;
            }
            Console.WriteLine("Qrupda heckim yoxdur cixarmaq ucun");
        }
        public void info()
        {
            Console.WriteLine("____");
            Console.WriteLine($"Qrup adi : {name}\nMaxYer sayi : {maxStuCount}");
            Console.WriteLine("___");
        }

        public Group(string name, int maxStuCount)
        {
            Name=name;
            MaxStuCount = maxStuCount;
        }
    }
}
