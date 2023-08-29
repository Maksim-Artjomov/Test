using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    internal class Student
    {
        public string Name { get; }
        public int age;
        private readonly string _city;
        public string status;
        public int birthday;

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }
        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                if (age < 18) status = "alaealine";
                else status = "täiskasvanud";
            }
        }
        public string Status
        {
            get { return status; }
        }

        public string GetCity()
        {
            return _city;
        }
        public int Birthday
        {
            get { return birthday; }
            set
            {
                age= value;
                birthday = ;
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
        }
    }
}
