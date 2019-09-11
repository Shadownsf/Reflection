using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace ExerciceBateau
{
    public class Bateau
    {
        [Custom("Property_bateau_name")]
        public string Name { get; set; }
        [Custom("Property_bateau_poids")]
        public int Poids { get; set; }
        [Custom("Property_bateau_Captain")]
        public Person Captain { get; set; }

        public Bateau()
        {
            Name = "Titan Nique";
            Poids = 800;
            Captain = new Person();
        }

    }
}
