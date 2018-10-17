using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Fox : Carnivore
    {
        public override int Bite { get { return Strength + 50; } }

        public override int Teeth { get => 25; }

        public override int Attack()
        {
            return Bite * Teeth;
        }

        public override int Eat()
        {
            Hunger = 25;
            return Hunger;

        }

        public override void Sound()
        {
            Console.WriteLine("FOX: AHHWOOO");
        }
    }
}
