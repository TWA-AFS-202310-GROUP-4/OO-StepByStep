using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep.Human
{
    public class Student : Person
    {
        private string words = "I am a student";
        private int classNum;

        public Student(string name, int age, int classNum = -1) : base(name, age)
        {
            this.classNum = classNum;
        }

        public override string Introduce()
        {
            string shouldSay = classNum < 0 ? words : $"{words} of class {classNum}";
            return $"{base.Introduce()} {shouldSay}.";
        }

        public void JoinClass(int classNum)
        {
            this.classNum = classNum;
        }
    }
}
