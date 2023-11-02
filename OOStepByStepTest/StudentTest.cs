using OOStepByStep;
using Xunit;

namespace OOStepByStepTest;

public class StudentTest
{
    [Fact]
    public void Should_return_name_age_and_occupation_when_introduce()
    {
        //Given
        var person = new Student("Tom", 18);
        //When
        var message = person.SelfIntroduce();
        //Then
        Assert.Equal("My name is Tom. I am 18 years old.I am a student", message);
    }
}