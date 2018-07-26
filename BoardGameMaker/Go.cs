using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public class Go:BoardLocation
    {
        public override string LocationType { get { return "Go"; } }
        public int MoneyWhenPassed;  //how much money you get when passing Go
        private int _MoneyWhenLand;   //how much money you get when landing on Go
        public int MoneyWhenLand
        {
            get { return _MoneyWhenLand; }
            set { this._MoneyWhenLand = MoneyWhenLand; }
        }

        public Go(string Name, string Description, int MoneyWhenPassed, int _MoneyWhenLand)
            :base(Name, Description)
        {
            this.MoneyWhenPassed = MoneyWhenPassed;
            this._MoneyWhenLand = _MoneyWhenLand;
            Console.WriteLine("I am creating a new Go");
        }

        public Go(Go previousGo) : base(previousGo.Name, previousGo.Description)
        {
            this._MoneyWhenLand = previousGo._MoneyWhenLand;
            this.MoneyWhenPassed = previousGo.MoneyWhenPassed;
        }

        ~Go()
        {
            Console.WriteLine("I'm destroying the Go named {0}", Name);
        }
    }
}
