using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public class Jail:BoardLocation
    {
        public override string LocationType { get { return "Jail"; } }
        public int RoundsInJail;
        public int PriceToLeave;
        private string _RollsThatGetYouOut;   //For example, rolling doubles
        public string RollsThatGetYouOut
        {
            get { return _RollsThatGetYouOut; }
            set { this._RollsThatGetYouOut = RollsThatGetYouOut; }
        }

        public Jail(string Name, string Description, int RoundsInJail, int PriceToLeave, string _RollsThatGetYouOut)
            :base(Name, Description)
        {
            this.RoundsInJail = RoundsInJail;
            this.PriceToLeave = PriceToLeave;
            this._RollsThatGetYouOut = _RollsThatGetYouOut;

            Console.WriteLine("I am creating a new Jail");
        }

        // copy constructor
        public Jail(Jail previousJail) : base(previousJail.Name, previousJail.Description)
        {
            this.RoundsInJail = previousJail.RoundsInJail;
            this.PriceToLeave = previousJail.PriceToLeave;
            this._RollsThatGetYouOut = previousJail.RollsThatGetYouOut;
        }

        ~Jail()
        {
            Console.WriteLine("I'm destroying the Jail named {0}", Name);
        }
    }
}
