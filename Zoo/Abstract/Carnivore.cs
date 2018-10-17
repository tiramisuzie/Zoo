using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract class Carnivore : Animal
    {
        public virtual int Teeth { get; set; }

        public abstract int Bite { get; set; }

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
