using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Teacher : Person
    {
        private int classNum;

        public Teacher(string name, int age) : base(name, age)
        {
            this.classNum = -1;
        }

        public Teacher(string name, int age, int classNum) : base(name, age)
        {
            this.classNum = classNum;
        }

        public string Introduce()
        {
            if (classNum != -1)
            {
                return base.Introduce() + $" I am a teacher of class {classNum}.";
            }
            else
            {
                return base.Introduce() + " I am a teacher.";
            }
        }
    }
}
