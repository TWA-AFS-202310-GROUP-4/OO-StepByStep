using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private List<Student> studentList;
        private Teacher teacher;

        public Class(int classNumber, List<Student> studentList)
        {
            this.studentList = studentList;
            ClassNumber = classNumber;
            studentList.ForEach(student => student.ClassNumber = classNumber);
        }

        public Class(int classNumber)
        {
            studentList = new List<Student>();
            ClassNumber = classNumber;
        }

        public int ClassNumber { get; set; }

        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
            teacher.ClassNumber = ClassNumber;
        }

        public string AddStudent(Student student)
        {
            studentList.Add(student);
            student.ClassNumber = ClassNumber;
            string msg = teacher.Introduce() + $"Welcome {student.Name} join class {ClassNumber}.";

            studentList.ForEach(stu =>
            {
                if (stu.Name != student.Name)
                {
                    string temp = stu.Introduce() + $"Welcome {student.Name} join class {ClassNumber}.";
                    msg += temp;
                }
            });
            return msg;
        }
    }
}
