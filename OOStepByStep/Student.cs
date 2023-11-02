using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Student : Person
    {
        public Student(int age, string name) : base(age, name)
        {
        }

        public int ClassNumber { get; set; } = -1;
        public override string Introduce()
        {
            if (ClassNumber != -1)
            {
                return base.Introduce() + $". I am a student of class {ClassNumber}";
            }

            return base.Introduce() + ". I am a student";
        }
    }
}
