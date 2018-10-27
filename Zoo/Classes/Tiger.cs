using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Tiger : Carnivore, ISleep
    {
        // abstract property from Carnivore
        public override int Teeth { get => 100; set => Teeth = value; }

        // property from ISleep
        public bool Asleep { get => true; set => Asleep = value; }

        // abstract method from carnivore
        public override int Aggression()
        {
            return 100;
        }

        public string name()
        {
            return "I am tig";
        }

        // Method from ISleep
        public string Nap()
        {
            return "ZZZZZZ";
        }
    }
}
