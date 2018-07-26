using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public abstract class GameItem
    {
        public string Name;
        public virtual string type { get {return "N/A"; } }

        public GameItem(string Name)
        {
            this.Name = Name;
            Console.WriteLine("I am creating a GameItem");

        }






    }
}
