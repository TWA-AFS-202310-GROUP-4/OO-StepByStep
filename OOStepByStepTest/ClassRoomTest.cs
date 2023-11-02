using OOStepByStep;
using System;
using System.Security.Cryptography;
using Xunit;

namespace OOStepByStepTest;

public class ClassRoomTest
{
    [Fact]
    public void Should_teacher_and_students_welcome_new_student()
    {
        //Given
        var teacher = new Teacher("Amy", 30, 2);
        var studentTom = new Student("Tom", 18, 2);
        var studentJack = new Student("Jack", 23, 2);
        var studentBob = new Student("Bob", 29, 2);

        var class2 = new ClassRoom(teacher, 2);
        class2.WelcomeStudents(studentTom);
        class2.WelcomeStudents(studentJack);

        //When
        var message = class2.WelcomeStudents(studentBob);
        Console.WriteLine(message);
        //Then
        Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2 Welcome Bob join class 2\n" +
                     "My name is Tom. I am 18 years old.I am a student of class 2 Welcome Bob join class 2\n" +
                     "My name is Jack. I am 23 years old.I am a student of class 2 Welcome Bob join class 2\n", message);
    }

    [Fact]
    public void Should_teacher_welcome_first_new_student()
    {
        //Given
        var teacher = new Teacher("Amy", 30, 2);
        var studentTom = new Student("Tom", 18, 2);
        var class2 = new ClassRoom(2);
        class2.AddTeacher(teacher);
        //When
        var message = class2.WelcomeStudents(studentTom);
        //Then
        Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2 Welcome Tom join class 2\n" +
                     "You are the first student in the class", message);
    }

    [Fact]
    public void Should_students_welcome_new_student()
    {
        //Given
        var studentTom = new Student("Tom", 18, 2);
        var studentJack = new Student("Jack", 23, 2);
        var studentBob = new Student("Bob", 29, 2);

        var class2 = new ClassRoom(2);
        class2.WelcomeStudents(studentTom);
        class2.WelcomeStudents(studentJack);

        //When
        var message = class2.WelcomeStudents(studentBob);
        Console.WriteLine(message);
        //Then
        Assert.Equal("My name is Tom. I am 18 years old.I am a student of class 2 Welcome Bob join class 2\n" +
                     "My name is Jack. I am 23 years old.I am a student of class 2 Welcome Bob join class 2\n", message);
    }

    [Fact]
    public void Should_be_the_first_student()
    {
        //Given
        var studentTom = new Student("Tom", 18, 2);
        var class2 = new ClassRoom(2);
        //When
        var message = class2.WelcomeStudents(studentTom);
        Console.WriteLine(message);
        //Then
        Assert.Equal("You are the first student in the class", message);
    }
}
