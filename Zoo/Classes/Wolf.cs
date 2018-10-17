using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Wolf : Carnivore
    {
        public override int Bite { get { return Strength + Teeth; } set { Teeth += value; } }

        public override void Eat()
        {
            Teeth += 100;
        }

        public override void Sleep()
        {
            Teeth = 0;
        }

        public override void Sound()
        {
            Console.WriteLine("Wolf: AHHHWOOO");
        }
    }
}
