using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Rhino : Herbivore
    {
        public override int Cuteness { get { return Affection; } set { Affection += value; } }

        public override void Eat()
        {
            Cuteness += 10;
        }

        public override void Sleep()
        {
            Cuteness += 100;
        }

        public override void Sound()
        {
            Console.WriteLine("Rhino: ARGHH");
        }
    }
}
