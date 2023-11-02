using OOStepByStep;
using OOStepByStep.Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class TestClassRoom
    {
        [Theory]
        [InlineData]
        public void Should_return_msg_when_join_student_given_empty_class()
        {
            var student = new Student("Tom", 10);
            int classNum = 1;
            var classRoom = new ClassRoom(classNum);
            var resExp = new Dictionary<string, List<string>>();
            resExp.Add("teacher", new List<string>());
            resExp.Add("students", new List<string>());

            Dictionary<string, List<string>> words = classRoom.Join(student);

            Assert.Equal(resExp, words);
        }

        [Theory]
        [InlineData]
        public void Should_return_msg_when_join_student_given_teacher()
        {
            string teacherName = "teacher";
            int teacherAge = 50;
            var teacher = new Teacher(teacherName, teacherAge);
            var student = new Student("Tom", 10);
            int classNum = 1;
            var classRoom = new ClassRoom(classNum);
            var resExp = new Dictionary<string, List<string>>();
            resExp.Add("teacher", new List<string>());
            resExp.Add("students", new ());
            resExp["teacher"].Add($"My name is {teacherName}. I am {teacherAge} years old. I am a teacher of class {classNum}. Welcome {student.Name()} join class {classNum}.");

            classRoom.Join(teacher);
            Dictionary<string, List<string>> words = classRoom.Join(student);

            Assert.Equal(resExp, words);
        }

        [Theory]
        [InlineData]
        public void Should_return_msg_when_join_student_given_student()
        {
            var student = new Student("Tom", 10);
            int classNum = 1;
            var classRoom = new ClassRoom(classNum);
            var resExp = new Dictionary<string, List<string>>();
            resExp.Add("teacher", new List<string>());
            resExp.Add("students", new ());
            resExp["students"].Add($"My name is {student.Name()}. I am {10} years old. I am a student of class {classNum}. Welcome student join class {classNum}.");
            var student2 = new Student("student", 12);

            classRoom.Join(student);
            Dictionary<string, List<string>> words = classRoom.Join(student2);

            Assert.Equal(resExp, words);
        }
    }
}
