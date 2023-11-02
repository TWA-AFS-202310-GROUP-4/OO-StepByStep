using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOStepByStep
{
    public class Class
    {
        public int ClassNumber { get; set; }
        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Class(int classnumber)
        {
            ClassNumber = classnumber;
        }

        public string Introduce(Person person)
        {
            if (person is Teacher && Teacher != null && (person.Name == Teacher.Name && person.Age == Teacher.Age))
            {
                var str = person.Introduce();
                return str.Remove(str.Length - 1) + " of class " + ClassNumber + ".";
            }
            else if (person is Student && Students.Contains(person))
            {
                var str = person.Introduce();
                return str.Remove(str.Length - 1) + " of class " + ClassNumber + ".";
            }

            return string.Empty;
        }
    }
}
