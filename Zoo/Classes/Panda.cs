using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Panda : Herbivore, ISleep
    {
        // override virtual property from herbivore
        public override int Happniess { get => 1000; set => Happniess = value; }
        
        // override virtual property from herbivore
        public override int Cutness { get => 1000; set => Cutness = value; }

        // property from ISleep
        public bool Asleep { get => true; set => Asleep = value; }

        // override virtual method from herbivore
        public override int Defense()
        {
            return 1000;
        }

        // override virtual method from herbivore
        public override int Affection()
        {
            return 1000;
        }

        public string Name()
        {
            return "I am pandee";
        }

        // method from ISleep
        public string Nap()
        {
            return "ZZZZZZ";
        }
    }
}
