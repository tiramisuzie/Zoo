using Zoo.Abstract;

namespace Zoo.Classes
{
    // derived class
    public class Animal : DemiGod
    {
        public int Strength { get; set; }

        public int Int { get; set; }

        // override abstract property from DemiGod
        public override int age { get => 9000; set => age = value; }
        
        public int Health()
        {
            return 100;
        }

        public int Stamia()
        {
            return 100;
        }

        // override Abstract method from DemiGod
        public override string SuperPower()
        {
            return "Magic";
        }
    }
}
