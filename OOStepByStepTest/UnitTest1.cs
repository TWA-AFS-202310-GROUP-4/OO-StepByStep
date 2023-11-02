namespace OOStepByStepTest
{
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
    }
}
