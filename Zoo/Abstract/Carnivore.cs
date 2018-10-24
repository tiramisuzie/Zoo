using Zoo.Abstract;

namespace Zoo.Classes
{
    // abstract class
    public abstract class Carnivore : Animal
    {
        public abstract int Teeth { get; set; }

        public abstract int Aggression();

        public string Eat()
        {
            return "I eat meat";
        }
    }
}
