using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Program2
{
    class Teacher : Person
    {
        private int yearsOfService;

        public Teacher(string name, int age, int id, Program program, int yearsOfService) : base(name, age, id, program)
        {
            this.yearsOfService = yearsOfService;
        }
    }
}
