using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string SelfIntroduce()
        {
            return IntroduceName() + " " + IntroduceAge();
        }

        private string IntroduceName()
        {
            return $"My name is {name}.";
        }

        private string IntroduceAge()
        {
            return $"I am {age} years old.";
        }
    }
}
