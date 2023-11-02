using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep;
public class Student : Person
{
    private int classRoomNumber;

    public Student(string name, int age) : base(name, age)
    {
        this.classRoomNumber = 0;
    }

    public Student(string name, int age, int classRoomNumber) : base(name, age)
    {
        this.classRoomNumber = classRoomNumber;
    }

    public override string SelfIntroduce()
    {
        if (this.classRoomNumber == 0)
        {
            return base.SelfIntroduce() + $"I am a student.";
        }
        else
        {
            return base.SelfIntroduce() + $"I am a student of class {classRoomNumber}";
        }
    }
}
