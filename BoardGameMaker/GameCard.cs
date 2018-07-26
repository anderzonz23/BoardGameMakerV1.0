using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public abstract class GameCard : GameItem
    {
        public virtual string CardType { get { return "N/A"; } }
        public override string type { get { return "Game Card"; } }
        public string Description;
        
        public GameCard(string Name, string Description):base(Name)
        {
            this.Description = Description;
            Console.WriteLine("I'm creating a GameCard");
        }
    }
}
