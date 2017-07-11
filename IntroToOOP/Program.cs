﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //When we initialize a new object, it is called INSTANTIATING (creating a new instance of that object)
            //An object needs to be instantiated before it can be used
            //All objects of a specific type are created in the same template - CLASS
            //To create new objects, create new classes (classes are like blueprints for what objects are going to be)
            //All objects from a class will have the same number and type of states, BUT...
            //each instance can have it's own unique values.

            //the format we use to instantiate an object look like this:
            //ClassName objectName = new ClassName();
            //Cat firstCat = new Cat(); //like what we did with Random which is an object

            //firstCat.Name = "Mittens";
            //Console.WriteLine(firstCat.Age);

            //Cat secondCat = new Cat("Oz", 3, "Orange and white"); //hover over the second Cat for options
            //secondCat.Name = "Ozzy";
            //Console.WriteLine(secondCat.Name); //this prints Ozzy to the console
            //Console.WriteLine(secondCat.Age);
            //secondCat.Eat(); //call Eat method

            Dog myDog = new Dog();
            Console.WriteLine(myDog.HairLength);
            Console.WriteLine(myDog.Height);
            myDog.Potty();




            //To create a new object, we use a special method called a CONSTRUCTOR

            //Thinking about objects in real life, create (either hand-write or type 3 examples of objects.
            //Your objects should have five states (characteristics) and five behaviors

            


        }
    }
}
