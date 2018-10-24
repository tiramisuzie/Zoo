using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Tiger : Carnivore
    {
        // abstract property from Carnivore
        public override int Teeth { get => 100; set => Teeth = value; }

        // abstract method from carnivore
        public override int Aggression()
        {
            return 100;
        }

        public string name()
        {
            return "I am tig";
        }
    }
}
