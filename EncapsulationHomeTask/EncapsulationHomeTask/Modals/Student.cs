using System;
using System.Collections.Generic;
using System.Text;

namespace EncapsulationHomeTask.Modals
{
    internal class Student
    {
        private int ID;
        private string Name;
        private string Surname;
        private string Specialty;

        public int id
        {
            get
            {
                return ID;
            }
            set
            {
                ID = value;
            }
        }
        public string name
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
        public string surname
        {
            get
            {
                return Surname;
            }
            set
            {
                Surname = value;
            }
        }
        public string specialty
        {
            get
            {
                return Specialty;
            }
            set
            {
                Specialty = value;
            }
        }

        public void info()
        {
            Console.WriteLine("____");
            Console.WriteLine($"ID : {id} \nAd : {name} \nSoyad : {surname} \nIxtisas : {specialty}");
            Console.WriteLine("____");
        }

        public Student(int id, string name, string surname, string specialty)
        {   ID = id;
            Name=name;
            Surname=surname;
            Specialty=specialty;
        }

    }
}
