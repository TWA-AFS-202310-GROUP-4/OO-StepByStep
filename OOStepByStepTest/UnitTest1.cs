namespace OOStepByStepTest
{
    using System.Xml.Linq;
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Theory]
        [InlineData("Tom", 12)]
        public void Should_return_introduce_name_and_age(string name, int age)
        {
            var p = new Person(name, age);
            var ret = p.Introduce();
            Assert.Equal($"My name is {name}. I am {age} years old.", ret);
        }

        [Theory]
        [InlineData("Tom", 12)]
        public void Should_return_introduce_name_and_age_and_teacher(string name, int age)
        {
            var p = new Teacher(name, age);
            var ret = p.Introduce();
            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher.", ret);
        }

        [Theory]
        [InlineData("Tom", 12)]
        public void Should_return_introduce_name_and_age_and_student(string name, int age)
        {
            var p = new Student(name, age);
            var ret = p.Introduce();
            Assert.Equal($"My name is {name}. I am {age} years old. I am a student.", ret);
        }

        [Theory]
        [InlineData("Tom", 12, 1)]
        public void Should_return_introduce_name_and_age_and_student_with_class(string name, int age, int classnum)
        {
            var classroom = new Class(classnum);
            var p = new Student(name, age);
            classroom.Students.Add(p);
            var ret = classroom.Introduce(p);
            Assert.Equal($"My name is {name}. I am {age} years old. I am a student of class {classnum}.", ret);
        }

        [Theory]
        [InlineData("Tom", 12, 1)]
        public void Should_return_introduce_name_and_age_and_notsame_student_with_class(string name, int age, int classnum)
        {
            var classroom = new Class(classnum);
            var p = new Student(name, age);
            classroom.Students.Add(p);
            var q = new Student("hh", 13);
            var ret = classroom.Introduce(q);
            Assert.Equal(string.Empty, ret);
        }

        [Theory]
        [InlineData("Tom", 30, 1)]
        public void Should_return_introduce_name_and_age_and_teacher_with_class(string name, int age, int classnum)
        {
            var classroom = new Class(classnum);
            classroom.Teacher = new Teacher(name, age);
            var ret = classroom.Introduce(classroom.Teacher);
            Assert.Equal($"My name is {name}. I am {age} years old. I am a teacher of class {classnum}.", ret);
        }

        [Theory]
        [InlineData("Tom", 30, 1)]
        public void Should_return_introduce_name_and_age_and_notsame_teacher_with_class(string name, int age, int classnum)
        {
            var classroom = new Class(classnum);
            var teacher = new Teacher(name, age);
            var ret = classroom.Introduce(teacher);
            Assert.True(ret == string.Empty);
        }
    }
}
