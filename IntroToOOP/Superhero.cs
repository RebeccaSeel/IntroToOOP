using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Superhero
    {
        //5 fields
        private string costume;
        private string name;
        private int strengthLevel;
        private string power;
        private bool hasCape;

        //4 properties
        public string Costume
        {
            get { return this.costume; }
            set { this.costume = value; }
        }

        public string Name
        {
            get { return this.name; }
        }

        //or
        //public string Name { get; }

        public int StrengthLevel
        {
            get { return this.strengthLevel; }
            set { this.strengthLevel = value; }
        }

        public string Power
        {
            get { return this.power; }
        }

        public bool HasCape
        {
            get { return this.hasCape; }
            set { this.hasCape = value; }
        }
        
        //3 constructors - have to declare default constructor if making more than one constructor

        public Superhero ()
        {
            //this is my default constructor
        }

        public Superhero (string name)
        {
            this.name = name;
            this.strengthLevel = 100; //if they use this constructor, strengthlevel always equals 100
        }

        public Superhero (string costume, string name, int strengthLevel, string power, bool hasCape)
        {
            this.costume = costume;
            this.name = name;
            this.strengthLevel = strengthLevel;
            this.power = power;
            this.hasCape = hasCape;
        }

        //2 methods
        public void BattleNemesis()
        {
            this.StrengthLevel -= 10; //strength level reduces by 10 during battle
            this.HasCape = false; //got ripped off in battle
            this.Costume = "tattered"; //costume gets ripped during battle
        }

        //public void GetHealthy(string costume, int strengthLevel)
        //{
        //    this.Costume = costume;
        //    this.StrengthLevel = strengthLevel;
        //}

        public void AllyGained()
        {
            this.StrengthLevel += 10;
            this.HasCape = false; //friends don't let friends where capes
            Console.WriteLine("Thank you for being a friend.");
        }
        
    }
}
