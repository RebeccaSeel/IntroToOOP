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

        private string name; //private is access modifer, typical for fields
        private int age; //declared
        private string furColor; //declared
        private bool isHungry = true; //set value

        //Properties - a sort of mix between a field and a method that allow controlled access

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
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
            //This is an example of a default contructor. A default contructor take no arguments/parameters
            //method that allows us to create cat object in main method
            //refers back to Cat mittens = new Cat() in the Program.cs

        }

        public Cat(string name, int age, string furColor)
        {
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }
    }
}
