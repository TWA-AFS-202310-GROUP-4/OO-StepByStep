using OOStepByStep;
using OOStepByStep.PesonType;
using System.Globalization;
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

        [Fact]
        public void Should_return_name_age_and_teacher_classid_when_teacher_SelfIntroduce_given_teacher_name_age_and_classid()
        {
            // Given
            var teacher = new Teacher("Amy", 22, 3);
            var expectedMes = "My name is Amy. I am 22 years old. I am a Teacher of Class 3.";
            //when
            var res = teacher.SelfIntroduce();

            //then
            Assert.Equal(expectedMes, res);
        }

        [Fact]
        public void Should_only_return_teacher_welcome__when_class_add_new_teacher_given_class_with_no_student()
        {
            // Given
            var student = new Student("Jim", 10);
            var teacher = new Teacher("Amy", 22);
            var class1 = new Class(3, teacher);
            //when
            var res = class1.AddNewStudent(student);
            var expectedMes = "My name is Amy. I am 22 years old. I am a Teacher of Class 3. Welcome Jim join class 3.";
            //then
            Assert.Equal(expectedMes, res);
        }

        [Fact]
        public void Should_only_return_teacher_welcome__when_class_add_new_teacher_given_class_with_student()
        {
            // Given
            var student1 = new Student("Jim", 10);
            var student2 = new Student("Bob", 3);
            var teacher = new Teacher("Amy", 22);
            var class1 = new Class(3, teacher);
            class1.AddNewStudent(student1);
            //when
            var res = class1.AddNewStudent(student2);
            var expectedMes = "My name is Amy. I am 22 years old. I am a Teacher of Class 3. Welcome Bob join class 3.\nMy name is Jim. I am 10 years old. I am a Student of Class 3. Welcome Bob join class 3.";
            //then
            Assert.Equal(expectedMes, res);
        }
    }
}
