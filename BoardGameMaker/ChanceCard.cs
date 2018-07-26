using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public class ChanceCard:GameCard, I_DrawableCard
    {
        public string WhenToDraw { get; set; }
        public string WhenToDiscard { get; set; }

        public override string CardType { get { return "Chance Card"; } }
        public bool GoodOrBad; //this sets if the card will do something good or bad, true = good, false = bad.


        public ChanceCard(string Name, string Description, bool GoodOrBad)
            :base(Name, Description)
        {
            this.GoodOrBad = GoodOrBad;
            Console.WriteLine("I am creating a Chance Card");
        }

        // copy constructor
        public ChanceCard(ChanceCard previousChanceCard) : base(previousChanceCard.Name, previousChanceCard.Description)
        {
            this.GoodOrBad = previousChanceCard.GoodOrBad;
        }

        public void Draw(string ThisHappens)
        {
            Console.WriteLine("{0} , Therefore, {1}", this.Description, ThisHappens);
        }

        ~ChanceCard()
        {
            Console.WriteLine("I'm destroying the Chance Card named {0}", Name);
        }
    }
}
