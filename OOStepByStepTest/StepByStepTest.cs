using OOStepByStep;
using OOStepByStep.PesonType;
using Xunit;

namespace OOStepByStepTest
{
    public class StepByStepTest
    {
        [Fact]
        public void Should_return_correct_name_and_age_when_people_Selfintroduce_given_name_and_age()
        {
            // Given
            var person = new Person("Tom", 20);
            var expectedMes = "My name is Tom. I am 20 years old.";
            //when
            var res = person.SelfIntroduce();

            //then
            Assert.Equal(expectedMes, res);
        }

        [Fact]
        public void Should_return_name_age_and_student_identity_when_student_SelfIntroduce_given_student_name_and_age()
        {
            // Given
            var student = new Student("Jim", 10);
            var expectedMes = "My name is Jim. I am 10 years old. I am a Student.";
            //when
            var res = student.SelfIntroduce();

            //then
            Assert.Equal(expectedMes, res);
        }

        [Fact]
        public void Should_return_name_age_and_teacher_identity_when_teacher_SelfIntroduce_given_teacher_name_and_age()
        {
            // Given
            var teacher = new Teacher("Amy", 22);
            var expectedMes = "My name is Amy. I am 22 years old. I am a Teacher.";
            //when
            var res = teacher.SelfIntroduce();

            //then
            Assert.Equal(expectedMes, res);
        }

        [Fact]
        public void Should_return_name_age_and_student_classid_when_student_SelfIntroduce_given_student_name_age_and_classid()
        {
            // Given
            var student = new Student("Jim", 10, 2);
            var expectedMes = "My name is Jim. I am 10 years old. I am a Student of Class 2.";
            //when
            var res = student.SelfIntroduce();

            //then
            Assert.Equal(expectedMes, res);
        }
    }
}
