using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public class PlayerPiece:GameItem
    {
        private string _Color;
        public string Color
        {
            get { return this._Color; }
            set { this._Color = Color; }
        }


        public string PhysicalDescription;
        public string SpecialAbility;
        public override string type { get { return "Player Piece"; } }


        public PlayerPiece(string Name, string _Color, string PhysicalDescription, string SpecialAbility)
            :base(Name)
        {
            this._Color = _Color;
            this.PhysicalDescription = PhysicalDescription;
            this.SpecialAbility = SpecialAbility;
        }

        public PlayerPiece(PlayerPiece previousPlayerPiece) : base(previousPlayerPiece.Name)
        {
            this._Color = previousPlayerPiece._Color;
            this.PhysicalDescription = previousPlayerPiece.PhysicalDescription;
            this.SpecialAbility = previousPlayerPiece.SpecialAbility;
        }

        ~PlayerPiece()
        {
            Console.WriteLine("I'm destroying the Player Piece named {0}", Name);
        }


    }
}
