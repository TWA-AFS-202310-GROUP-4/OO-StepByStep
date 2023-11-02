using System;
using System.Collections.Generic;
using OOStepByStep;
using Xunit;

namespace OOStepByStepTest
{
    public class ClassroomTests
    {
        [Fact]
        public void Should_return_empty_string_when_welcome_given_no_one_in_class_with_first_comer_student()
        {
            // Given
            var classroom = new Classroom(2);

            // When
            Student s1 = new Student("Amy", 21);
            string result = classroom.WelcomeNewcomer(s1);

            // Then
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Should_return_empty_string_when_welcome_given_no_one_in_class_with_first_comer_teacher()
        {
            // Given
            var classroom = new Classroom(2);

            // When
            Teacher s1 = new Teacher("Amy", 42);
            string result = classroom.WelcomeNewcomer(s1);

            // Then
            Assert.Equal(string.Empty, result);
        }

        [Fact]
        public void Should_return_welcome_string_when_welcome_given_one_teacher_in_class()
        {
            // Given
            Teacher t1 = new Teacher("Amy", 42, 2);
            Student s1 = new Student("Andy", 20, 2);
            var classroom = new Classroom(t1, 2);
            var expected = "My name is Amy. I am 42 years old. I am a teacher of class 2. Welcome Andy join class 2.\n";

            // When
            string result = classroom.WelcomeNewcomer(s1);

            // Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_return_welcome_string_when_welcome_given_one_student_in_class()
        {
            // Given
            Teacher t1 = new Teacher("Amy", 42, 2);
            Student s1 = new Student("Andy", 20, 2);
            List<Student> students = new List<Student>();
            students.Add(s1);
            var classroom = new Classroom(students, 2);
            var expected = "My name is Andy. I am 20 years old. I am a student of class 2. Welcome Amy join class 2.\n";

            // When
            string result = classroom.WelcomeNewcomer(t1);

            // Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_return_welcome_string_when_welcome_given_one_student_one_teacher_in_class()
        {
            // Given
            Teacher t1 = new Teacher("Amy", 42, 2);
            Student s1 = new Student("Andy", 20, 2);
            Student s2 = new Student("Pocky", 2, 2);
            List<Student> students = new List<Student>();
            students.Add(s1);
            var classroom = new Classroom(t1, students, 2);
            var expected = "My name is Andy. I am 20 years old. I am a student of class 2. Welcome Pocky join class 2.\nMy name is Amy. I am 42 years old. I am a teacher of class 2. Welcome Pocky join class 2.\n";

            // When
            string result = classroom.WelcomeNewcomer(s2);

            // Then
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Should_return_welcome_string_when_welcome_given_two_students_in_class()
        {
            // Given
            Teacher t1 = new Teacher("Amy", 42, 2);
            Student s1 = new Student("Andy", 20, 2);
            Student s2 = new Student("Pocky", 2, 2);
            List<Student> students = new List<Student>();
            students.Add(s1);
            students.Add(s2);
            var classroom = new Classroom(students, 2);
            var expected = "My name is Andy. I am 20 years old. I am a student of class 2. Welcome Amy join class 2.\nMy name is Pocky. I am 2 years old. I am a student of class 2. Welcome Amy join class 2.\n";

            // When
            string result = classroom.WelcomeNewcomer(t1);

            // Then
            Assert.Equal(expected, result);
        }
    }
}
