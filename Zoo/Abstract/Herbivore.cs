using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Herbivore : Animal
    {
        public virtual int Affection { get; set; }

        public abstract int Cuteness { get; set; }

        public virtual int Pose()
        {
            return Affection + 20;
        }
    }
}
