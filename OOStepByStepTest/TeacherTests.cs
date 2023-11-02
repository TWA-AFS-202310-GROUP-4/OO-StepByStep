using OOStepByStep;
using System;
using Xunit;

namespace OOStepByStepTest
{
    public class TeacherTests
    {
        [Theory]
        [InlineData("Tom", 18)]
        [InlineData("Amy", 30)]
        [InlineData("Pocky", 2)]
        public void Should_return_name_age_teacher_when_introduce_given_input_name_age_teacher(string name, int age)
        {
            // Given
            var teacher = new Teacher(name, age);

            // When
            var result = teacher.Introduce();

            // Then
            var expected = $"My name is {name}. I am {age} years old. I am a teacher.";
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Tom", 18, 2)]
        [InlineData("Amy", 30, 3)]
        [InlineData("Pocky", 2, 4)]
        public void Should_return_name_age_teacher_class_num_when_introduce_given_input_name_age_teacher_classnum(string name, int age, int classNum)
        {
            // Given
            var teacher = new Teacher(name, age, classNum);

            // When
            var result = teacher.Introduce();

            // Then
            var expected = $"My name is {name}. I am {age} years old. I am a teacher of class {classNum}.";
            Assert.Equal(expected, result);
        }
    }
}
