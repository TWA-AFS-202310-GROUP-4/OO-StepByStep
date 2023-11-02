namespace OOStepByStepTest;

using OOStepByStep;
using Xunit;

public class PersonTest
{
    [Fact]
    public void Should_return_name_and_age_when_introduce()
    {
        //Given
        var person = new Person("Tom", 21);
        //When
        var message = person.SelfIntroduce();
        //Then
        Assert.Equal("My name is Tom. I am 21 years old.", message);
    }
}
