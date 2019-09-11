using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Program2
{
    class Person
    {
        
        public string name;
        public int age;
        public int id;
        public Program program;

        public Person(string name, int age, int id, Program program)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.program = program;
        }
    }
}
