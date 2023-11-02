using OOStepByStep.PesonType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        private Teacher? teacher;
        private List<Student> students;
        private int classid;

        public Class(int classid, Teacher teacher)
        {
            this.classid = classid;
            teacher.Classid = classid;
            this.teacher = teacher;

            students = new List<Student>();
        }

        public string AddNewStudent(Student newComer)
        {
            var commonWel = ShowWeclomeSentence(newComer.Name);
            if (students.Count == 0)
            {
                newComer.Classid = classid;
                students.Add(newComer);
                var techerWelcome = teacher.SelfIntroduce() + " " + commonWel;
                return techerWelcome;
            }

            return commonWel;
        }

        private string ShowWeclomeSentence(string newStuName)
        {
            return $"Welcome {newStuName} join class {classid}.";
        }
    }
}
