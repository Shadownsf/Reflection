using System;

namespace Models
{
    [Custom("Test Attribute")]
    public class Person
    {
        [Custom("User Name")]
        public string Name { get; set; }

        [Custom("User Age")]
        public int Age { get; set; }

        [Custom("User NumSecu")]
        public string NumeroDeSecu { get; set; }

        [Custom("Constructor Person")]
        public Person()
        {
            Name = "Toto";
            Age = 15;
            NumeroDeSecu = "0123456789";
        }

        [Custom("IncrementAge")]
        public int IncrementAge()
        {
            Age = ++Age;
            return Age;
        }
    }
}
