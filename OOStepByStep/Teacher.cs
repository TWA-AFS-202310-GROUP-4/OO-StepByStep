using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep;

public class Teacher : Person
{
    private int classRoomNumber;
    public Teacher(string name, int age) : base(name, age)
    {
        this.classRoomNumber = 0;
    }

    public Teacher(string name, int age, int classRoomNumber) : base(name, age)
    {
        this.classRoomNumber = classRoomNumber;
    }

    public override string SelfIntroduce()
    {
        if (classRoomNumber == 0)
        {
            return base.SelfIntroduce() + $" I am a teacher";
        }
        else
        {
            return base.SelfIntroduce() + $" I am a teacher of class {classRoomNumber}";
        }
    }
}
