
namespace Models
{
    public class Bateau
    {
        public string Name { get; set; }

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
