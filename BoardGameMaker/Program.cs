using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameMaker
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var NewYork = new PropertyCard("New York Avenue", "3rd piece of orange set", "orange", 150, 200, 16, 32, 100);
            var GoToJail = new ChanceCard("Go To Jail", "Sends you to jail", false);
            var Go1 = new Go("Go1", "Regular Go location", 200, 400);
            var Jail1 = new Jail("Jail1", "Regular Jail Location", 3, 50, "doubles");
            var Ship = new PlayerPiece("Ship", "silver", "Looks like a tugboat", "Can go under properties it doesn't like");
            var BankError = new CommunityCard("Bank Error", "Bank made error in your favor, recieve $100", true);
            var FreeParking1 = new FreeParking("FreeParking1", "Regular Free Parking", true);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
