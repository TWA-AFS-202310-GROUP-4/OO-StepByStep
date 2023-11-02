using OOStepByStep;
using System;
using Xunit;

namespace OOStepByStepTest
{
    public class PersonTests
    {
        [Theory]
        [InlineData("Tom", 18)]
        [InlineData("Amy", 30)]
        [InlineData("Pocky",2)]
        public void Should_return_name_and_age_when_introduce_given_input_name_and_age(string name, int age)
        {
            // Given
            var person = new Person(name, age);

            // When
            var result = person.Introduce();

            // Then
            var expected = $"My name is {name}. I am {age} years old.";
            Assert.Equal(expected, result);
        }
    }
}
