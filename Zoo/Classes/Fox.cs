using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Fox : Carnivore, IHunt
    {
        // override abstract property from Carnivore
        public override int Teeth { get => 50; set => Teeth = value; }

        // property from IHunt interface
        public int Energy { get => 50; set => Energy = value; }

        // override abstract method from Carnivore
        public override int Aggression()
        {
            return 0;
        }

        // my method
        public string name()
        {
            return "I am a Fox";
        }

        // method from IHunt interface
        public string Weapon()
        {
            return "teeth and claws";
        }
    }
}
