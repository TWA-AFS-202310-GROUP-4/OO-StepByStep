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
    }
}
