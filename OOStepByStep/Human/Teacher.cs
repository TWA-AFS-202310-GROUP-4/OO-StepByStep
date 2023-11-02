using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep.Human
{
    public class Teacher : Person
    {
        private string words = "I am a teacher";
        private int classNum;

        public Teacher(string name, int age, int classNum = -1) : base(name, age)
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
