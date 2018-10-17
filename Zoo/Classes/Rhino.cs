using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Rhino : Herbivore
    {
        // override Abstract properties from Animal class
        public override int Cuteness { get { return Cuteness; } set { Cuteness = value; } }

        // override Abstract method from Animal class
        public override int Eat()
        {
            Hunger = 50;
            return Hunger;
        }

        // override Abstract method from Animal class
        public override int Attack()
        {
            Strength = 1000;
            return Strength;
        }

        // override Abstract method from Animal class
        public override void Sound()
        {
            Console.WriteLine("Rhino: ...");
        }

        // override virtual properties from Animal class
        public override int Affection { get { return Affection + 2000; } set { Affection = value; } }
    }
}
