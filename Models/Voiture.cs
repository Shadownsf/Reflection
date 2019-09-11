using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public interface IVehicule
    {
    }

    public class Voiture : IVehicule
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public int OwnerID { get; set; }
        public string Brand { get; set; }

        public Voiture()
        {
            Name = "VogueMerry";
            SerialNumber = "Y0139836";
            OwnerID = 1;
            Brand = "kellogg's";
        }
    }
}
