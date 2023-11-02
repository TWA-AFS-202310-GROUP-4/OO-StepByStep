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
            var welcome = teacher.SelfIntroduce() + " " + commonWel;
            newComer.Classid = classid;
            if (students.Count == 0)
            {
                students.Add(newComer);
                return welcome;
            }

            welcome = welcome + "\n";
            foreach (var student in students)
            {
                welcome += string.Join("\n", student.SelfIntroduce() + " " + commonWel);
            }

            students.Add(newComer);
            return welcome;
        }

        private string ShowWeclomeSentence(string newStuName)
        {
            return $"Welcome {newStuName} join class {classid}.";
        }
    }
}
