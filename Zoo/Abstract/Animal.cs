using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animal
    {
        public virtual int Strength { get; set; }

        public virtual int Hunger { get; set; }

        public abstract int Eat();

        public abstract int Attack();

        public abstract void Sound();
    }
}
