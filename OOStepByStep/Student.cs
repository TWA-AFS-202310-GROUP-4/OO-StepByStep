using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        private int classNum;

        public Student(string name, int age) : base(name, age)
        {
            this.classNum = -1;
        }

        public Student(string name, int age, int classNum) : base(name, age)
        {
            this.classNum = classNum;
        }

        public override string Introduce()
        {
            if (this.classNum == -1)
            {
                return base.Introduce() + " I am a student.";
            }
            else
            {
                return base.Introduce() + $" I am a student of class {classNum}.";
            }
        }
    }
}
