using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Carnivore : Animal
    {
        public virtual int Teeth { get; }

        public abstract int Bite { get; }

        public virtual bool Catch(int affection)
        { 
            if (affection < 50)
            {
                return true;
            }
            return false;
        }
    }
}
