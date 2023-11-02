using OOStepByStep;
using OOStepByStep.Human;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OOStepByStepTest
{
    public class TestHuman
    {
        [Theory]
        [InlineData]
        public void Should_return_msg_when_introduce()
        {
            var name = "Tom";
            var age = 10;
            var p = new Person(name, age);
            var resExpect = $"My name is {name}. I am {age} years old.";

            var res = p.Introduce();

            Assert.Equal(resExpect, res);
        }

        [Theory]
        [InlineData]
        public void Should_student_return_msg_when_introduce()
        {
            var name = "Tom";
            var age = 10;
            var p = new Student(name, age);
            var resExpect = $"My name is {name}. I am {age} years old. I am a student.";

            var res = p.Introduce();

            Assert.Equal(resExpect, res);
        }

        [Theory]
        [InlineData]
        public void Should_Teacher_return_msg_when_introduce()
        {
            var name = "Tom";
            var age = 10;
            var p = new Teacher(name, age);
            var resExpect = $"My name is {name}. I am {age} years old. I am a teacher.";

            var res = p.Introduce();

            Assert.Equal(resExpect, res);
        }

        [Theory]
        [InlineData]
        public void Should_student_of_class_return_msg_when_introduce()
        {
            var name = "Tom";
            var age = 10;
            var p = new Student(name, age, 1);
            var resExpect = $"My name is {name}. I am {age} years old. I am a student of class 1.";

            var res = p.Introduce();

            Assert.Equal(resExpect, res);
        }

        [Theory]
        [InlineData]
        public void Should_teacher_of_class_return_msg_when_introduce()
        {
            var name = "Tom";
            var age = 10;
            var p = new Teacher(name, age, 1);
            var resExpect = $"My name is {name}. I am {age} years old. I am a teacher of class 1.";

            var res = p.Introduce();

            Assert.Equal(resExpect, res);
        }
    }
}
