namespace OOStepByStepTest
{
    using OOStepByStep;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void Should_return_introduction_message_given_person()
        {
            var person = new Person(2, "xianke");
            string msg = person.Introduce();

            Assert.Equal("My name is xianke. I am 2 years old", msg);
        }

        [Fact]
        public void Should_return_introduction_message_given_student()
        {
            var stu = new Student(2, "student1");
            string msg = stu.Introduce();

            Assert.Equal("My name is student1. I am 2 years old. I am a student", msg);
        }

        [Fact]
        public void Should_return_introduction_message_given_teacher()
        {
            var tea = new Teacher(2, "teacher1");
            string msg = tea.Introduce();

            Assert.Equal("My name is teacher1. I am 2 years old. I am a teacher", msg);
        }
    }
}
