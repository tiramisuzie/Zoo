using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Tiger : Carnivore
    {
        public override int Bite { get { return Strength + 9000; } }

        public override int Teeth { get => 9000; }

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
            Console.WriteLine("Tiger: RAWR");
        }
    }
}
