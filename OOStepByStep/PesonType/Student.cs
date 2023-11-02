using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep.PesonType
{
    public class Student : Person
    {
        public Student(string name, int age) : base(name, age)
        {
        }

        public Student(string name, int age, int classid) : base(name, age)
        {
            this.Classid = classid;
        }

        public int? Classid { get; set; }

        public override string SelfIntroduce()
        {
            if (Classid == null)
            {
                return base.SelfIntroduce() + " " + "I am a Student.";
            }

            return base.SelfIntroduce() + " " + $"I am a Student of Class {Classid}.";
        }
    }
}
