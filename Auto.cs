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
       // dit is readonly prop zonder keyword readonly
        public int DagWaarde
        {
            get { return (500000 / KmStand) * (int)Brandstof; ; }
        }


        public Auto(string kenteken, BrandstofSoort brandstofSoort)
        {
            Kenteken = kenteken;
            Brandstof = brandstofSoort;
        }

        public void RijdKilometers(int getal)
        {
            if (getal > 0)
            {
                KmStand += getal;
            }
        }

        
    }

        

    
}
