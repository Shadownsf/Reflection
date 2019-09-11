using System;

namespace Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string NumeroDeSecu { get; set; }

        public Person()
        {
            Name = "Toto";
            Age = 15;
            NumeroDeSecu = "0123456789";
        }

        public int IncrementAge()
        {
            Age = ++Age;
            return Age;
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}
