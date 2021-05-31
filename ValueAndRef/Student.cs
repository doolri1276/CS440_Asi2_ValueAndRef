using System;
using System.Collections.Generic;
using System.Text;

namespace ValueAndRef
{
    class Student
    {
        string name;

        public Student(string name)
        {
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
    }
}
