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
            var expected = $"My name is {name}. I am {age} years old. I am a student.";
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Tom", 18, 2)]
        [InlineData("Amy", 30, 3)]
        [InlineData("Pocky", 2, 4)]
        public void Should_return_name_age_student_classnum_when_introduce_given_input_name_age_student_classnum(string name, int age, int classNum)
        {
            // Given
            var student = new Student(name, age, classNum);

            // When
            var result = student.Introduce();

            // Then
            var expected = $"My name is {name}. I am {age} years old. I am a student of class {classNum}.";
            Assert.Equal(expected, result);
        }
    }
}
