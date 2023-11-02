using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOStepByStep;

public class ClassRoom
{
    private Teacher teacher;
    private List<Student> studentList;
    private int classRoomNumber;

    public ClassRoom(int classRoomNumber)
    {
        this.teacher = null;
        this.studentList = new List<Student>();
        this.classRoomNumber = classRoomNumber;
    }

    public ClassRoom(Teacher teacher, int classRoomNumber)
    {
        this.teacher = teacher;
        this.studentList = new List<Student>();
        this.classRoomNumber = classRoomNumber;
    }

    public ClassRoom(Teacher teacher, List<Student> studentList, int classRoomNumber)
    {
        this.teacher = teacher;
        this.studentList = new List<Student>();
        this.classRoomNumber = classRoomNumber;
        this.studentList = studentList;
    }

    public void AddTeacher(Teacher teacher)
    {
        this.teacher = teacher;
    }

    public string WelcomeStudents(Student newStudent)
    {
        string output = string.Empty;

        if (teacher != null)
        {
            output += teacher.SelfIntroduce() + $" Welcome {newStudent.GetName()} join class {classRoomNumber}" + "\n";
        }

        if (studentList.Count == 0)
        {
            studentList.Add(newStudent);
            output += "You are the first student in the class";
            return output;
        }
        else
        {
            studentList.ForEach(student =>
            {
                output += student.SelfIntroduce() + $" Welcome {newStudent.GetName()} join class {classRoomNumber}" + "\n";
            });
        }

        studentList.Add(newStudent);

        return output;
    }
}
