using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Program2
{
    class Student : Person
    {
        private int creditsEarned;

        public Student(string name, int age, int id, Program program, int creditsEarned) : base (name, age, id, program)
        {
            this.creditsEarned = creditsEarned;
        }
    }
}
