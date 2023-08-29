using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proovi
{
    public class Student
    {
        public string Name { get; }
        public int Age;
        private readonly string _city;
        public string status;
        public int dateTime
        {
            
        }

        public Student(string name, int age, string city)
        {
            Name = name;
            Age = age;
            _city = city;
        }

        public string Status
        { 
            get { return status; } 
            set 
            { 
                status = value; 
                if (Age<18)                
                status = "alaealine";
                else status = "täiskasvanud";
                
            }
        }

        public string GetCity()
        {
            return _city;
        }
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(GetCity());
            Console.WriteLine(Status);
        }

    }
}