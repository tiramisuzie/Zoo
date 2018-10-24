using Zoo.Abstract;

namespace Zoo.Classes
{
    public abstract class Herbivore : Animal
    {
        public virtual int Cutness { get; set; }

        public virtual int Happniess { get; set; }

        public virtual int Affection()
        {
            return 100;
        }

        public virtual int Defense()
        {
            return 50;
        }

        public string Eat()
        {
            return "I eat vegetable";
        }
    }
}
