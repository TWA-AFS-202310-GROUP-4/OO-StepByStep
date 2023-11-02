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
    }
}
