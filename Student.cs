using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeExample
{
    [Serializable]
    internal class Student
    {
        public int Age { get; set; }
        public string Name { get; set;}

        public Student() 
        {
            Name = "akash";
            Age = 11;
        }

        public void Display()
        {
            Console.WriteLine($"Age : {Age}  Name : {Name}");
        }
    }
}
