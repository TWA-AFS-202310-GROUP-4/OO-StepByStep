using OOStepByStep;
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
    }
}
