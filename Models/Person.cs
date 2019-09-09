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
    }
}
