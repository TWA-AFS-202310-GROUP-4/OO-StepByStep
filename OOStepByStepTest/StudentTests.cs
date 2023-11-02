using OOStepByStep;
using System;
using System.Security.Cryptography;
using Xunit;

namespace OOStepByStepTest
{
    public class StudentTests
    {
        [Theory]
        [InlineData("Tom", 18)]
        [InlineData("Amy", 30)]
        [InlineData("Pocky", 2)]
        public void Should_return_name_age_student_when_introduce_given_input_name_age_student(string name, int age)
        {
            // Given
            var student = new Student(name, age);

            // When
            var result = student.Introduce();

            // Then
            var expected = $"My name is {name}. I am {age}. I am a student.";
            Assert.Equal(expected, result);
        }
    }
}
