using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Wolf : Carnivore
    {
        public override int Bite { get { return Strength + 50; } }

        public override int Teeth { get => 250; }

        public override int Attack()
        {
            return Bite * Teeth;
        }

        public override int Eat()
        {
            Hunger = 60;
            return Hunger;

        }

        public override void Sound()
        {
            Console.WriteLine("Wolf: AHHWOOO");
        }
    }
}
