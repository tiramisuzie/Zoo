﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Panda : Herbivore
    {
        public override int Cuteness { get { return Affection; } set { Affection += value; } }

        public override void Eat()
        {
            Cuteness += 100;
        }

        public override void Sleep()
        {
            Cuteness += 1000;
        }

        public override void Sound()
        {
            Console.WriteLine("Panda: ...");
        }

        public override int Affection { get { return Affection + 20; } set { Affection = value; } }
    }
}
