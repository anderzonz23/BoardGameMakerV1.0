using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public class CommunityCard:GameCard, I_DrawableCard
    {
        public string WhenToDraw { get; set; }
        public string WhenToDiscard { get; set; }

        public override string CardType { get { return "Community Card"; } }
        public bool GoodOrBad; //this sets if the card will do something good or bad, true = good, false = bad.

        public CommunityCard(string Name, string Description, bool GoodOrBad)
            :base(Name, Description)
        {
            this.GoodOrBad = GoodOrBad;
            Console.WriteLine("I am creating a Community Card");
        }

        // copy constructor
        public CommunityCard(CommunityCard previousCommunityCard) : base(previousCommunityCard.Name, previousCommunityCard.Description)
        {
            this.GoodOrBad = previousCommunityCard.GoodOrBad;
        }

        public void Draw(string ThisHappens)
        {
            Console.WriteLine("{0} , Therefore, {1}", this.Description, ThisHappens);
        }
        
        ~CommunityCard()
        {
            Console.WriteLine("I'm destroying the Community Card named {0}", Name);
        }
    }
}
