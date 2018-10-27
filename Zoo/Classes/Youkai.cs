using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Youkai : Panda, IHunt, ISleep
    {
        // Property from IHunt
        public int Energy { get => 1000; set => Energy = value; }

        // Property from ISleep
        public bool Asleep { get => true; set => Asleep = value; }

        public string Name()
        {
            return "I am a Youkai";
        }

        // method from ISleep
        public string Nap()
        {
            return "I am sleeping";
        }

        // method from IHunt
        public string Weapon()
        {
            return "Energy Blast";
        }
    }
}
