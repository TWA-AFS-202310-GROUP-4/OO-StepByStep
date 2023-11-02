namespace OOStepByStepTest
{
    using OOStepByStep;
    using System.Collections.Generic;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_introduction_message_given_person()
        {
            var person = new Person(2, "xianke");
            string msg = person.Introduce();

            Assert.Equal("My name is xianke. I am 2 years old.", msg);
        }

        [Fact]
        public void Should_return_introduction_message_given_student()
        {
            var stu = new Student(2, "student1");
            string msg = stu.Introduce();

            Assert.Equal("My name is student1. I am 2 years old. I am a student.", msg);
        }

        [Fact]
        public void Should_return_introduction_message_given_teacher()
        {
            var tea = new Teacher(2, "teacher1");
            string msg = tea.Introduce();

            Assert.Equal("My name is teacher1. I am 2 years old. I am a teacher.", msg);
        }

        [Fact]
        public void Should_return_introduction_message_given_When_teacher_belong_to_class()
        {
            Class cl = new Class(2);
            var tea = new Teacher(2, "teacher1");
            cl.AddTeacher(tea);
            string msg = tea.Introduce();

            Assert.Equal("My name is teacher1. I am 2 years old. I am a teacher of class 2.", msg);
        }

        [Fact]
        public void Should_return_introduction_message_given_When_student_belong_to_class()
        {
            var stu = new Student(2, "student1");
            List<Student> stulist = new List<Student> { stu };
            Class cl = new Class(2, stulist);

            string msg = stu.Introduce();

            Assert.Equal("My name is student1. I am 2 years old. I am a student of class 2.", msg);
        }

        [Fact]
        public void Should_return_introduction_message_given_When_student_join_a_class()
        {
            var stu1 = new Student(2, "student1");
            List<Student> stulist = new List<Student> { stu1 };
            Class cl = new Class(2, stulist);
            var stu2 = new Student(2, "student2");
            Teacher teacher = new Teacher(2, "teacher1");
            cl.AddTeacher(teacher);
            string msg = cl.AddStudent(stu2);

            Assert.Equal("My name is teacher1. I am 2 years old. " +
                "I am a teacher of class 2.Welcome student2 join class 2.My name is student1. I am 2 years old. " +
                "I am a student of class 2.Welcome student2 join class 2.", msg);
        }
    }
}
