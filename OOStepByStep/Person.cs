using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public virtual string SelfIntroduce()
        {
            return IntroduceName() + " " + IntroduceAge();
        }

        private string IntroduceName()
        {
            return $"My name is {Name}.";
        }

        private string IntroduceAge()
        {
            return $"I am {Age} years old.";
        }
    }
}
