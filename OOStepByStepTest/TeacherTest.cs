using OOStepByStep;
using Xunit;

namespace OOStepByStepTest;
public class TeacherTest
{
    [Fact]
    public void Should_return_name_age_and_occupation_when_introduce()
    {
        //Given
        var person = new Teacher("Amy", 30);
        //When
        var message = person.SelfIntroduce();
        //Then
        Assert.Equal("My name is Amy. I am 30 years old. I am a teacher", message);
    }

    [Fact]
    public void Should_return_name_age_occupation_and_classnumber_when_introduce()
    {
        //Given
        var person = new Teacher("Amy", 30, 2);
        //When
        var message = person.SelfIntroduce();
        //Then
        Assert.Equal("My name is Amy. I am 30 years old. I am a teacher of class 2", message);
    }
}
