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

        public void AddStudent(Student student)
        {
            studentList.Add(student);
            student.ClassNumber = ClassNumber;
        }
    }
}
