using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Dog
    {
        //Create a Dog class
        //Your dog class should have fields for hair length, height, running speed, and weight
        //Your class should have the following behaviors: run, bark, potty, cuddle
        //should have at least one constructor
        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;
        private bool crap = true;

        //properties
        public int HairLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        public int RunningSpeed
        {
            get { return this.runningSpeed;}
            set { this.runningSpeed = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        //short way to do the properties above = public double BarkVolume {get; set;}
        //example - creates BarkVolume property behind the scenes, like an invisibility cloak
        //cannot do this shorter version if you want to set conditions
        public double BarkVolume { get; set; }
        //also allowed public double BarkVolume {get;}

        //should have at least one constructor
        public Dog()
        {
            //this is my default constructor
            this.height = 2;
            this.weight = 75;
            this.runningSpeed = 10;
        }

        public Dog(int hairLength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        //Your class should have the following behaviors: run, bark, potty, cuddle

        //public void Run()
        //{
        //    Console.WriteLine("Go doggy go!!");
        //}   

        public int Run()
        {
            Console.WriteLine("Go doggy go!!");
            RunningSpeed -= 1;
            return RunningSpeed;
        }
        
        public void Bark()
        {
            Console.WriteLine("Bork bork bork!!");
            
        }
      
        public void Potty()
        {
            if (crap == true)
            {
                Console.WriteLine("Your dog just made a mess!");
            }
            else
            {
                Console.WriteLine("Your dog has to relieve itself!");
            }
        }

        public void Cuddle()
        {
            Console.WriteLine("Aww, doggo is so sweet.");
        }


    }
}
