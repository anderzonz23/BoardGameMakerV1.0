using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public abstract class BoardLocation:GameItem
    {
        public override string type { get { return "Board Location"; } }
        public virtual string LocationType { get { return "N/A"; } }
        public string Description;

        public BoardLocation(string Name, string Description)
            :base(Name)
        {
            this.Description = Description;
            Console.WriteLine("I'm creating a new Board Location");
        }
    }
}
