namespace OOStepByStep
{
    using System;
    public class Person
    {
        private int age;
        private string name;

        public Person(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public string Name
        {
            get { return name; }
        }

        public virtual string Introduce()
        {
            return $"My name is {name}. I am {age} years old.";
        }
    }
}
