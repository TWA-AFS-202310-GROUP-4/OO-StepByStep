using OOStepByStep.Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class ClassRoom
    {
        private int classNum;
        private Teacher teacher = null;
        private List<Student> students = new ();

        public ClassRoom(int classNum)
        {
            this.classNum = classNum;
        }

        public Dictionary<string, List<string>> Join(Student student)
        {
            var toSay = $"Welcome {student.Name()} join class {classNum}.";
            var res = new Dictionary<string, List<string>>();
            res.Add("teacher", new ());
            res.Add("students", new ());

            if (teacher != null)
            {
                var teacherSay = teacher.Introduce() + " " + toSay;
                res["teacher"].Add(teacherSay);
            }

            foreach (var s in students)
            {
                var studentSay = s.Introduce() + " " + toSay;
                res["students"].Add($"{studentSay}");
            }

            student.JoinClass(classNum);
            this.students.Add(student);

            return res;
        }

        public bool Join(Teacher teacher)
        {
            if (this.teacher == null)
            {
                teacher.JoinClass(classNum);
                this.teacher = teacher;
                return true;
            }

            return false;
        }
    }
}
