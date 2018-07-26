using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGameMaker
{
    public class PropertyCard:GameCard, I_HoldableCard
    {
        public string WhenToDiscard { get; set; }
        public string WhenToUse { get; set; }

        public override string CardType { get { return "Property Card"; } }
        public string Color;
        public int PriceForHouse;
        public int Price;
        public int Rent;
        public int RentColorMatch;
        private int _RentWithHouse;
        public int RentWithHouse
        {
            get { return _RentWithHouse; }
            set { this._RentWithHouse = RentWithHouse; }
        }

        public static bool operator <(PropertyCard self, PropertyCard other)
        {
            return self.Price < other.Price;
        }
        public static bool operator >(PropertyCard self, PropertyCard other)
        {
            return self.Price > other.Price;
        }
        public static bool operator <=(PropertyCard self, PropertyCard other)
        {
            return self.Price <= other.Price;
        }
        public static bool operator >=(PropertyCard self, PropertyCard other)
        {
            return self.Price >= other.Price;
        }
        public static bool operator ==(PropertyCard self, PropertyCard other)
        {
            return self.Price == other.Price;
        }
        public static bool operator !=(PropertyCard self, PropertyCard other)
        {
            return self.Price != other.Price;
        }

        public PropertyCard(string Name, string Description, string Color, int PriceForHouse, int Price, int Rent, int RentColorMatch, int _RentWithHouse)
            :base(Name, Description)
        {
            this.Color = Color;
            this.Price = Price;
            this.PriceForHouse = PriceForHouse;
            this.Rent = Rent;
            this.RentColorMatch = RentColorMatch;
            this._RentWithHouse = _RentWithHouse;
            Console.WriteLine("I am creating a Property Card");
        
        }

        // copy constructor
        public PropertyCard(PropertyCard previousPropertyCard) : base(previousPropertyCard.Name, previousPropertyCard.Description)
        {
            this.Color = previousPropertyCard.Color;
            this.Price = previousPropertyCard.Price;
            this.PriceForHouse = previousPropertyCard.PriceForHouse;
            this.Rent = previousPropertyCard.Rent;
            this.RentColorMatch = previousPropertyCard.RentColorMatch;
            this._RentWithHouse = previousPropertyCard._RentWithHouse;
        }

        public void UseCard(string ThisHappens)
        {
            Console.WriteLine("{0} , Therefore, {1}", this.Description, ThisHappens);
        }

        ~PropertyCard()
        {
            Console.WriteLine("I'm destroying the Property Card named {0}", Name);
        }
    }
}
