using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep.PesonType
{
    public class Student : Person
    {
        private int? classid;
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classid) : base(name, age)
        {
            this.classid = classid;
        }

        public override string SelfIntroduce()
        {
            if (classid == null)
            {
                return base.SelfIntroduce() + " " + "I am a Student.";
            }

            return base.SelfIntroduce() + " " + $"I am a Student of Class {classid}.";
        }
    }
}
