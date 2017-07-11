using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Cat
    {
        //Inside of our class, we create the blueprint for our object.
        //Classes are templates in OOP that we use to create objects.
        //They should always to named in Pascal case.

        //In OOP, there are two types of States:
        //Fields - variables that belong to a class
        //camelCase when naming fields

        private string name; //private is access modifer, typical for fields
        private int age; //declared
        private string furColor; //declared
        private bool isHungry = true; //set value

        //Properties - a sort of mix between a field and a method that allow controlled access
        //need to do a property for each field
        //Properties are mama bear, fields are baby bears re: access to baby bears

        public string Name
        {
            get { return this.name; } //only returns the name, if not goes to set to set the name -- ; is INSIDE {}
            set { this.name = value; } //value is a keyword, value sets the name - this.name is placeholder for a specific object
        }

        public int Age
        {
            get { return this.age; } //can only get the age, cannot set it (no user input allowed)

        }

        //We also have Behaviors.
        //Methods - repeatable or reusable sections of code - Actions
        //Constructors - specialized methods that are used when instantiating an object
        //  - Allow us to control the state of an object upon creation.
        //  - Allow us to perform any actions the object might need upon creation.
        //  - Always share the name of the class
        //In this example, the constructor is Cat

        public Cat() //constructor
        {
            this.age = 1;
            this.name = "Kitty";
            //This is an example of a default contructor. A default contructor take no arguments/parameters
            //method that allows us to create cat object in main method
            //refers back to Cat mittens = new Cat() in the Program.cs
            //allows for user input

        }
        //can have as many contructors as you need as long as they each have a unique signature/
        //by signature, I mean the parameters after the contructor name. Data types must be different, including order
        public Cat(string name, int age, string furColor)
        {
            this.name = name; //hover over first name and second name tells you what it is referring back to
            this.age = age;
            this.furColor = furColor;
        }
        //overloading, involves using same contructor with different signatures
        public Cat(string name, int age)
        {
            this.name = name; //hover over first name and second name tells you what it is referring back to
            this.age = age;
        }

        public void Eat()
        {
            if (isHungry)
            {
                isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " + isHungry);
        }
    }
}
