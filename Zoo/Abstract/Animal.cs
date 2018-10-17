using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Animal
    {
        string Name;

        public virtual int Strength { get; set; }

        public abstract void Eat();

        public abstract void Sound();

        public abstract void Sleep();
    }
}
