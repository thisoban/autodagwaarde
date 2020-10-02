using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDagWaarde
{
    public class Auto
    {
        private int KilometerStand;
        public BrandstofSoort Brandstof;
        public int KmStand { get; private set; } = 1;

        private readonly string Kenteken;
        private readonly int DagWaarde { get;  return (500000 / kilometerstand) * (int)Brandstof)}
        public Auto(string kenteken, BrandstofSoort brandstofSoort)
        {
            Kenteken = kenteken;
            Brandstof = brandstofSoort;
        }

        public int RijdKilometers(int getal)
        {
            if (getal > 0)
            {
                return getal;
            }

            return getal;
        }

        
    }

        

    
}
