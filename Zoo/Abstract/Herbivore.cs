using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Herbivore : Animal
    {
        public virtual int Affection { get; set; }

        public abstract int Cuteness { get; set; }

        public virtual int Run()
        {
            return Affection + 20;
        }
    }
}
