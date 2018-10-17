using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Fox : Carnivore
    {
        public override int Bite { get { return Teeth; } set { Teeth = value; } }
        
        public override void Eat()
        {
            Bite += 40;
        }

        public override void Sleep()
        {
            Bite = 0;
        }

        public override void Sound()
        {
            Console.WriteLine("Fox: WRAHHHH");
        }
    }
}
