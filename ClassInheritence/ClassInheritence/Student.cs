using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritence
{
    class Student
    {
        private string[] names = new string[25];
        public string this [int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
        public int Age { get; set; }
        public string Name { get; set; }

        public Student(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }
    }
}
