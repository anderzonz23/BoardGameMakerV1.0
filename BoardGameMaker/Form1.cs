using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoardGameMaker
{
    public partial class Form1 : Form
    {
        public string button;
        public int counter = 0;
        public int propertycounter = 1;
        public int playercounter = 1;
        public int chancecounter = 1;
        public int communitycounter = 1;
        public int jailcounter = 1;
        public int gocounter = 1;
        public int parkingcounter = 1;

        public string name;
        public string description;
        public string color;
        public string rolls;
        public int landgo;
        public int passgo;
        public int pricetoleave;
        public int roundsinjail;
        public int houseprice;
        public int price;
        public int rent;
        public int rentcolormatch;
        public int rentwithhouse;
        public string ability;
        public bool GorB = false;
        public PropertyCard property1 = null;
        string property1N = "null";
        public PropertyCard property2 = null;
        string property2N = "null";
        public PropertyCard property3 = null;
        string property3N = "null";
        public PlayerPiece player1 = null;
        string player1N = "null";
        public PlayerPiece player2 = null;
        string player2N = "null";
        public PlayerPiece player3 = null;
        string player3N = "null";
        public ChanceCard chance1 = null;
        string chance1N = "null";
        public ChanceCard chance2 = null;
        string chance2N = "null";
        public ChanceCard chance3 = null;
        string chance3N = "null";
        public CommunityCard community1 = null;
        string community1N = "null";
        public CommunityCard community2 = null;
        string community2N = "null";
        public CommunityCard community3 = null;
        string community3N = "null";
        public Jail jail1 = null;
        string jail1N = "null";
        public Jail jail2 = null;
        string jail2N = "null";
        public Jail jail3 = null;
        string jail3N = "null";
        public Go go1 = null;
        string go1N = "null";
        public Go go2 = null;
        string go2N = "null";
        public Go go3 = null;
        string go3N = "null";
        public FreeParking parking1 = null;
        string parking1N = "null";
        public FreeParking parking2 = null;
        string parking2N = "null";
        public FreeParking parking3 = null;
        string parking3N = "null";
        public bool PropDelete = false;
        public bool PlayDelete = false;
        public bool ChanceDelete = false;
        public bool CommunityDelete = false;
        public bool JailDelete = false;
        public bool GoDelete = false;
        public bool ParkingDelete = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void NewPropertyCard_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "New Property Card. Please input the Name below: ";
            button = "NewProperty";

        }

        private void NewPlayerPiece_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "New Player Piece. Please input the Name below: ";
            button = "NewPlayer";
        }

        private void NewChanceCard_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "New Chance Card. Please input the Name below: ";
            button = "NewChance";

        }

        private void NewCommunityCard_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "New Community Card. Please input the Name below: ";
            button = "NewCommunity";
        }

        private void NewJail_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "New Jail location. Please input the Name below: ";
            button = "NewJail";
        }

        private void NewGo_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "New Go location. Please input the Name below: ";
            button = "NewGo";
        }

        private void NewFreeParking_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "New Free Parking. Please input the Name below: ";
            button = "NewParking";
        }

        private void DeletePlayerPiece_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter the name of the player you wish to delete: ";
            button = "DeletePlayer";
        }

        private void DeletePropertyCard_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter the name of the property you wish to delete: ";
            button = "DeleteProperty";  
        }

        private void DeleteChanceCard_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter the name of the chance card you wish to delete: ";
            button = "DeleteChance";
        }

        private void DeleteCommunityCard_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter the name of the community card you wish to delete: ";
            button = "DeleteCommunity";
        }

        private void DeleteJail_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter the name of the jail you wish to delete: ";
            button = "DeleteJail";

        }

        private void DeleteGo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter the name of the Go you wish to delete: ";
            button = "DeleteGo";
        }

        private void DeleteFreeParking_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Please enter the name of the Free Parking you wish to delete: ";
            button = "DeleteParking";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private string input = string.Empty;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            input = textBox2.Text;



        }

        private void Enter_Click(object sender, EventArgs e)
        {

            if (button == "NewProperty")
            {
                switch (counter)
                {
                    case 0:
                        this.name = textBox2.Text;
                        if (propertycounter == 1)
                            property1N = textBox2.Text;
                        else if (propertycounter == 2)
                            property2N = textBox2.Text;
                        else if (propertycounter == 3)
                            property3N = textBox2.Text;
                        textBox1.Text = "Please enter description of property: ";
                        textBox2.Text = "";
                        break;
                    case 1:
                        description = textBox2.Text;
                        textBox1.Text = "Please enter color of property: ";
                        textBox2.Text = "";
                        break;
                    case 2:
                        color = textBox2.Text;
                        textBox1.Text = "Please enter Price per house: ";
                        textBox2.Text = "";
                        break;
                    case 3:
                        int x = Int32.Parse(textBox2.Text);
                        houseprice = x;
                        textBox1.Text = "Please enter Price to buy Property: ";
                        textBox2.Text = "";
                        break;
                    case 4:
                        int y = Int32.Parse(textBox2.Text);
                        price = y;
                        textBox1.Text = "Please enter the normal Rent amount: ";
                        textBox2.Text = "";
                        break;
                    case 5:
                        int z = Int32.Parse(textBox2.Text);
                        rent = z;
                        textBox1.Text = "Please enter Rent amount with color match: ";
                        textBox2.Text = "";
                        break;
                    case 6:
                        int w = Int32.Parse(textBox2.Text);
                        rentcolormatch = w;
                        textBox1.Text = "Please enter Rent amount with a House: ";
                        textBox2.Text = "";
                        break;
                    case 7:
                        int q = Int32.Parse(textBox2.Text);
                        rentwithhouse = q;
                        if (propertycounter == 1)
                        {
                            property1 = new PropertyCard(this.name, description, color, houseprice, price, rent, rentcolormatch, rentwithhouse);
                            propertycounter++;
                        }
                        else if (propertycounter == 2)
                        {
                            property2 = new PropertyCard(this.name, description, color, houseprice, price, rent, rentcolormatch, rentwithhouse);
                            propertycounter++;
                        }
                        else if (propertycounter == 3)
                        {
                            property3 = new PropertyCard(this.name, description, color, houseprice, price, rent, rentcolormatch, rentwithhouse);
                            propertycounter++;
                        }
                        string finaltext = string.Concat("Property Card created named ", this.name);
                        textBox1.Text = finaltext;
                        textBox2.Text = "";
                        break;
                }

                if (counter == 7)
                    counter = 0;
                else
                    counter++;
            }
            else if (button == "NewPlayer")
            {
                switch (counter)
                {
                    case 0:
                        this.name = textBox2.Text;
                        if (playercounter == 1)
                            player1N = textBox2.Text;
                        else if (playercounter == 2)
                            player2N = textBox2.Text;
                        else if (playercounter == 3)
                            player3N = textBox2.Text;
                        textBox1.Text = "Please enter Physical description of player: ";
                        textBox2.Text = "";
                        break;
                    case 1:
                        description = textBox2.Text;
                        textBox1.Text = "Please enter color of player: ";
                        textBox2.Text = "";
                        break;
                    case 2:
                        color = textBox2.Text;
                        textBox1.Text = "Please enter special ability of player: ";
                        textBox2.Text = "";
                        break;
                    case 3:
                        ability = textBox2.Text;
                        if (playercounter == 1)
                        {
                            player1 = new PlayerPiece(this.name, color, description, ability);
                            playercounter++;
                        }
                        else if (playercounter == 2)
                        {
                            player2 = new PlayerPiece(this.name, color, description, ability);
                            playercounter++;
                        }
                        else if (playercounter == 3)
                        {
                            player3 = new PlayerPiece(this.name, color, description, ability);
                            playercounter++;
                        }
                        string finaltext = string.Concat("Player Piece created named ", this.name);
                        textBox1.Text = finaltext;
                        textBox2.Text = "";
                        break;

                }

                if (counter == 3)
                    counter = 0;
                else
                    counter++;
            }
            else if (button == "NewJail")
            {
                switch (counter)
                {
                    case 0:
                        this.name = textBox2.Text;
                        if (jailcounter == 1)
                            jail1N = textBox2.Text;
                        else if (jailcounter == 2)
                            jail2N = textBox2.Text;
                        else if (jailcounter == 3)
                            jail3N = textBox2.Text;
                        textBox1.Text = "Please enter description of jail: ";
                        textBox2.Text = "";
                        break;
                    case 1:
                        description = textBox2.Text;
                        textBox1.Text = "Please enter number of rounds spent in jail: ";
                        textBox2.Text = "";
                        break;
                    case 2:
                        int q = Int32.Parse(textBox2.Text);
                        roundsinjail = q;
                        textBox1.Text = "Please enter price to leave jail: ";
                        textBox2.Text = "";
                        break;
                    case 3:
                        int x = Int32.Parse(textBox2.Text);
                        pricetoleave = x;
                        textBox1.Text = "Please enter which rolls gets you out of jail: ";
                        textBox2.Text = "";
                        break;
                    case 4:
                        rolls = textBox2.Text;
                        if (jailcounter == 1)
                        {
                            jail1 = new Jail(this.name, description, roundsinjail, pricetoleave, rolls);
                            jailcounter++;
                        }
                        else if (jailcounter == 2)
                        {
                            jail2 = new Jail(this.name, description, roundsinjail, pricetoleave, rolls);
                            jailcounter++;
                        }
                        else if (jailcounter == 3)
                        {
                            jail3 = new Jail(this.name, description, roundsinjail, pricetoleave, rolls);
                            jailcounter++;
                        }
                        string finaltext = string.Concat("jail location created named ", this.name);
                        textBox1.Text = finaltext;
                        textBox2.Text = "";
                        break;

                }

                if (counter == 4)
                    counter = 0;
                else
                    counter++;
            }
            else if (button == "NewParking")
            {
                switch (counter)
                {
                    case 0:
                        this.name = textBox2.Text;
                        if (parkingcounter == 1)
                            parking1N = textBox2.Text;
                        else if (parkingcounter == 2)
                            parking2N = textBox2.Text;
                        else if (parkingcounter == 3)
                            parking3N = textBox2.Text;
                        textBox1.Text = "Please enter description of free parking: ";
                        textBox2.Text = "";
                        break;
                    case 1:
                        description = textBox2.Text;
                        textBox1.Text = "Please select if Free Parking collects money from players' payments to the game (yes, no): ";
                        textBox2.Text = "";
                        break;
                    case 2:
                        if (textBox2.Text == "yes")
                            GorB = true;
                        
                        if (parkingcounter == 1)
                        {
                            parking1 = new FreeParking(this.name, description, GorB);
                            parkingcounter++;
                        }
                        else if (parkingcounter == 2)
                        {
                            parking2 = new FreeParking(this.name, description, GorB);
                            parkingcounter++;
                        }
                        else if (parkingcounter == 3)
                        {
                            parking3 = new FreeParking(this.name, description, GorB);
                            parkingcounter++;
                        }
                        string finaltext = string.Concat("free parking location created named ", this.name);
                        textBox1.Text = finaltext;
                        textBox2.Text = "";
                        break;
                }

                if (counter == 2)
                    counter = 0;
                else
                    counter++;
            }
            else if (button == "NewGo")
            {
                switch (counter)
                {
                    case 0:
                        this.name = textBox2.Text;
                        if (gocounter == 1)
                            go1N = textBox2.Text;
                        else if (gocounter == 2)
                            go2N = textBox2.Text;
                        else if (gocounter == 3)
                            go3N = textBox2.Text;
                        textBox1.Text = "Please enter description of Go: ";
                        textBox2.Text = "";
                        break;
                    case 1:
                        description = textBox2.Text;
                        textBox1.Text = "Please enter money won when landing on Go: ";
                        textBox2.Text = "";
                        break;
                    case 2:
                        int q = Int32.Parse(textBox2.Text);
                        landgo = q;
                        textBox1.Text = "Please enter money won when passing Go: ";
                        textBox2.Text = "";
                        break;
                    case 3:
                        int x = Int32.Parse(textBox2.Text);
                        passgo = x;
                        if (gocounter == 1)
                        {
                            go1 = new Go(this.name, description, passgo, landgo);
                            gocounter++;
                        }
                        else if (gocounter == 2)
                        {
                            go2 = new Go(this.name, description, passgo, landgo);
                            gocounter++;
                        }
                        else if (gocounter == 3)
                        {
                            go3 = new Go(this.name, description, passgo, landgo);
                            gocounter++;
                        }
                        string finaltext = string.Concat("Go location created named ", this.name);
                        textBox1.Text = finaltext;
                        textBox2.Text = "";
                        break;
                }

                if (counter == 3)
                    counter = 0;
                else
                    counter++;
            }
            else if (button == "NewChance")
            {
                switch (counter)
                {
                    case 0:
                        this.name = textBox2.Text;
                        if (chancecounter == 1)
                            chance1N = textBox2.Text;
                        else if (chancecounter == 2)
                            chance2N = textBox2.Text;
                        else if (chancecounter == 3)
                            chance3N = textBox2.Text;
                        textBox1.Text = "Please enter description of chance card: ";
                        textBox2.Text = "";
                        break;
                    case 1:
                        description = textBox2.Text;
                        textBox1.Text = "Is this chance card good or bad? (enter good or bad): ";
                        textBox2.Text = "";
                        break;
                    case 2:
                        if (textBox2.Text == "good")
                            GorB = true;

                        if (chancecounter == 1)
                        {
                            chance1 = new ChanceCard(this.name, description, GorB);
                            chancecounter++;
                        }
                        else if (chancecounter == 2)
                        {
                            chance2 = new ChanceCard(this.name, description, GorB);
                            chancecounter++;
                        }
                        else if (chancecounter == 3)
                        {
                            chance3 = new ChanceCard(this.name, description, GorB);
                            chancecounter++;
                        }
                        string finaltext = string.Concat("chance card created named ", this.name);
                        textBox1.Text = finaltext;
                        textBox2.Text = "";
                        break;

                }

                if (counter == 2)
                    counter = 0;
                else
                    counter++;
            }
            else if (button == "NewCommunity")
            {
                switch (counter)
                {
                    case 0:
                        this.name = textBox2.Text;
                        if (communitycounter == 1)
                            community1N = textBox2.Text;
                        else if (communitycounter == 2)
                            community2N = textBox2.Text;
                        else if (communitycounter == 3)
                            community3N = textBox2.Text;
                        textBox1.Text = "Please enter description of community card: ";
                        textBox2.Text = "";
                        break;
                    case 1:
                        description = textBox2.Text;
                        textBox1.Text = "Is this community card good or bad? (enter good or bad): ";
                        textBox2.Text = "";
                        break;
                    case 2:
                        if (textBox2.Text == "good")
                            GorB = true;

                        if (communitycounter == 1)
                        {
                            community1 = new CommunityCard(this.name, description, GorB);
                            communitycounter++;
                        }
                        else if (communitycounter == 2)
                        {
                            community2 = new CommunityCard(this.name, description, GorB);
                            communitycounter++;
                        }
                        else if (communitycounter == 3)
                        {
                            community3 = new CommunityCard(this.name, description, GorB);
                            communitycounter++;
                        }
                        string finaltext = string.Concat("community card created named ", this.name);
                        textBox1.Text = finaltext;
                        textBox2.Text = "";
                        break;

                }

                if (counter == 2)
                    counter = 0;
                else
                    counter++;
            }
            else if (button == "DeletePlayer")
            {
                PlayDelete = false;
                name = textBox2.Text;
                if (player1N != "null")
                {
                    if (player1.Name == name)
                    {
                        string f = string.Concat("player Card named " + name + " deleted ");
                        textBox1.Text = f;
                        player1 = null;
                        player1N = "null";
                        playercounter = 0;
                        PlayDelete = true;
                    }
                }
                if (player2N != "null" && PlayDelete == false)
                {
                    if (player2.Name == name)
                    {
                        string f = string.Concat("player Card named " + name + " deleted ");
                        textBox1.Text = f;
                        player2 = null;
                        player2N = "null";
                        playercounter = 1;
                        PlayDelete = true;
                    }
                }
                if (player3N != "null" && PlayDelete == false)
                {
                    if (player3.Name == name)
                    {
                        string f = string.Concat("player piece named " + name + " deleted ");
                        textBox1.Text = f;
                        player3 = null;
                        player3N = "null";
                        playercounter = 2;
                        PlayDelete = true;
                    }
                }
                if (PlayDelete == false)
                    textBox1.Text = "No player with that name exists ";

                textBox2.Text = "";
            }
            else if (button == "DeleteJail")
            {
                JailDelete = false;
                name = textBox2.Text;
                if (jail1N != "null")
                {
                    if (jail1.Name == name)
                    {
                        string f = string.Concat("jail named " + name + " deleted ");
                        textBox1.Text = f;
                        jail1 = null;
                        jail1N = "null";
                        jailcounter = 0;
                        JailDelete = true;
                    }
                }
                if (jail2N != "null" && JailDelete == false)
                {
                    if (jail2.Name == name)
                    {
                        string f = string.Concat("jail named " + name + " deleted ");
                        textBox1.Text = f;
                        jail2 = null;
                        jail2N = "null";
                        jailcounter = 1;
                        JailDelete = true;
                    }
                }
                if (jail3N != "null" && JailDelete == false)
                {
                    if (jail3.Name == name)
                    {
                        string f = string.Concat("jail named " + name + " deleted ");
                        textBox1.Text = f;
                        jail3 = null;
                        jail3N = "null";
                        jailcounter = 2;
                        JailDelete = true;
                    }
                }
                if (JailDelete == false)
                    textBox1.Text = "No jail with that name exists ";

                textBox2.Text = "";
            }
            else if (button == "DeleteParking")
            {
                ParkingDelete = false;
                name = textBox2.Text;
                if (parking1N != "null")
                {
                    if (parking1.Name == name)
                    {
                        string f = string.Concat("free parking named " + name + " deleted ");
                        textBox1.Text = f;
                        parking1 = null;
                        parking1N = "null";
                        parkingcounter = 0;
                        ParkingDelete = true;
                    }
                }
                if (parking2N != "null" && ParkingDelete == false)
                {
                    if (parking2.Name == name)
                    {
                        string f = string.Concat("free parking named " + name + " deleted ");
                        textBox1.Text = f;
                        parking2 = null;
                        parking2N = "null";
                        parkingcounter = 1;
                        ParkingDelete = true;
                    }
                }
                if (parking3N != "null" && ParkingDelete == false)
                {
                    if (parking3.Name == name)
                    {
                        string f = string.Concat("free parking named " + name + " deleted ");
                        textBox1.Text = f;
                        parking3 = null;
                        parking3N = "null";
                        parkingcounter = 2;
                        ParkingDelete = true;
                    }
                }
                if (ParkingDelete == false)
                    textBox1.Text = "No free parking with that name exists ";

                textBox2.Text = "";
            }
            else if (button == "DeleteGo")
            {
                GoDelete = false;
                name = textBox2.Text;
                if (go1N != "null")
                {
                    if (go1.Name == name)
                    {
                        string f = string.Concat("Go named " + name + " deleted ");
                        textBox1.Text = f;
                        go1 = null;
                        go1N = "null";
                        gocounter = 0;
                        GoDelete = true;
                    }
                }
                if (go2N != "null" && GoDelete == false)
                {
                    if (go2.Name == name)
                    {
                        string f = string.Concat("Go named " + name + " deleted ");
                        textBox1.Text = f;
                        go2 = null;
                        go2N = "null";
                        gocounter = 1;
                        GoDelete = true;
                    }
                }
                if (go3N != "null" && GoDelete == false)
                {
                    if (go3.Name == name)
                    {
                        string f = string.Concat("Go named " + name + " deleted ");
                        textBox1.Text = f;
                        go3 = null;
                        go3N = "null";
                        gocounter = 2;
                        GoDelete = true;
                    }
                }
                if (GoDelete == false)
                    textBox1.Text = "No Go with that name exists ";

                textBox2.Text = "";
            }
            else if (button == "DeleteChance")
            {
                ChanceDelete = false;
                name = textBox2.Text;
                if (chance1N != "null")
                {
                    if (chance1.Name == name)
                    {
                        string f = string.Concat("chance Card named " + name + " deleted ");
                        textBox1.Text = f;
                        chance1 = null;
                        chance1N = "null";
                        chancecounter = 0;
                        ChanceDelete = true;
                    }
                }
                if (chance2N != "null" && ChanceDelete == false)
                {
                    if (chance2.Name == name)
                    {
                        string f = string.Concat("chance Card named " + name + " deleted ");
                        textBox1.Text = f;
                        chance2 = null;
                        chance2N = "null";
                        chancecounter = 1;
                        ChanceDelete = true;
                    }
                }
                if (chance3N != "null" && ChanceDelete == false)
                {
                    if (chance3.Name == name)
                    {
                        string f = string.Concat("chance piece named " + name + " deleted ");
                        textBox1.Text = f;
                        chance3 = null;
                        chance3N = "null";
                        chancecounter = 2;
                        ChanceDelete = true;
                    }
                }
                if (ChanceDelete == false)
                    textBox1.Text = "No chance card with that name exists ";

                textBox2.Text = "";
            }
            else if (button == "DeleteCommunity")
            {
                CommunityDelete = false;
                name = textBox2.Text;
                if (community1N != "null")
                {
                    if (community1.Name == name)
                    {
                        string f = string.Concat("community Card named " + name + " deleted ");
                        textBox1.Text = f;
                        community1 = null;
                        community1N = "null";
                        communitycounter = 0;
                        CommunityDelete = true;
                    }
                }
                if (community2N != "null" && CommunityDelete == false)
                {
                    if (community2.Name == name)
                    {
                        string f = string.Concat("community Card named " + name + " deleted ");
                        textBox1.Text = f;
                        community2 = null;
                        community2N = "null";
                        communitycounter = 1;
                        CommunityDelete = true;
                    }
                }
                if (community3N != "null" && CommunityDelete == false)
                {
                    if (community3.Name == name)
                    {
                        string f = string.Concat("community piece named " + name + " deleted ");
                        textBox1.Text = f;
                        community3 = null;
                        community3N = "null";
                        communitycounter = 2;
                        CommunityDelete = true;
                    }
                }
                if (CommunityDelete == false)
                    textBox1.Text = "No community card with that name exists ";

                textBox2.Text = "";
            }
            else if (button == "DeleteProperty")
            {
                PropDelete = false;
                name = textBox2.Text;
                if (property1N != "null")
                {
                    if (property1.Name == name)
                    {
                        string f = string.Concat("Property Card named " + name + " deleted ");
                        textBox1.Text = f;
                        property1 = null;
                        property1N = "null";
                        propertycounter = 0;
                        PropDelete = true;
                    }
                }
                if (property2N != "null" && PropDelete == false)
                {
                    if (property2.Name == name)
                    {
                        string f = string.Concat("Property Card named " + name + " deleted ");
                        textBox1.Text = f;
                        property2 = null;
                        property2N = "null";
                        propertycounter = 1;
                        PropDelete = true;
                    }
                }
                if (property3N != "null" && PropDelete == false)
                {
                    if (property3.Name == name)
                    {
                        string f = string.Concat("Property Card named " + name + " deleted ");
                        textBox1.Text = f;
                        property3 = null;
                        property3N = "null";
                        propertycounter = 2;
                        PropDelete = true;
                    }
                }
                if (PropDelete == false)
                    textBox1.Text = "No property with that name exists ";

                textBox2.Text = "";
            }
        }
    }
}
