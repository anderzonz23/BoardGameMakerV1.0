using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public class FreeParking:BoardLocation
    {
        public override string LocationType { get { return "Free Parking"; } }
        public bool CollectsMoney;  /* This sets whether or not free parking collects money given to the game through bad board locations, 
                                        chance cards, and community cards. All of which is collected when landing on free parking. */
        
        public FreeParking(string Name, string Description, bool CollectsMoney)
            :base(Name, Description)
        {
            this.CollectsMoney = CollectsMoney;
            Console.WriteLine("I am creating a new Free Parking");
        }

        public FreeParking(FreeParking previousFreeParking) : base(previousFreeParking.Name, previousFreeParking.Description)
        {
            this.CollectsMoney = previousFreeParking.CollectsMoney;
        }

        ~FreeParking()
        {
            Console.WriteLine("I'm destroying the Free Parking named {0}", Name);
        }
    }
}
