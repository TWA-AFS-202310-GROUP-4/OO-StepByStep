using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Classroom
    {
        private Teacher teacher;
        private List<Student> students = new List<Student>();
        private int classNum;

        public Classroom(int classNum)
        {
            this.classNum = classNum;
        }

        public Classroom(List<Student> students, int classNum)
        {
            this.classNum = classNum;
            this.students = students;
        }

        public Classroom(Teacher teacher, int classNum)
        {
            this.teacher = teacher;
            this.classNum = classNum;
        }

        public Classroom(Teacher teacher, List<Student> students, int classNum)
        {
            this.teacher = teacher;
            this.students = students;
            this.classNum = classNum;
        }

        public string WelcomeNewcomer(Person newcomer)
        {
            string welcomeMessage = string.Empty;
            for (int i = 0; i < students.Count; i++)
            {
                welcomeMessage += students[i].Introduce() + $" Welcome {newcomer.GetName()} join class {classNum}.\n";
            }

            if (newcomer.GetType() == typeof(Teacher))
            {
                this.teacher = new Teacher(newcomer.GetName(), newcomer.GetAge());
            }

            else
            {
                if (teacher != null)
                {
                    welcomeMessage += teacher.Introduce() + $" Welcome {newcomer.GetName()} join class {classNum}.\n";
                }

                students.Add(new Student(newcomer.GetName(), newcomer.GetAge()));
            }

            return welcomeMessage;
        }
    }
}
