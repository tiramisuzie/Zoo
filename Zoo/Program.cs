using System;
using Zoo.Classes;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fox");
            Fox fox = new Fox();
            Console.WriteLine("from Carnivore");
            Console.WriteLine(fox.Eat());
            Console.WriteLine("from Animal");
            Console.WriteLine(fox.Health());
            Console.WriteLine("from DemiGod");
            Console.WriteLine(fox.SuperPower());
            Console.WriteLine("from IHunt");
            Console.WriteLine(fox.Weapon());

            Console.WriteLine();

            Console.WriteLine("Panda");
            Panda panda = new Panda();
            Console.WriteLine("from Herbivore");
            Console.WriteLine(panda.Eat());
            Console.WriteLine("from Animal");
            Console.WriteLine(panda.Health());
            Console.WriteLine("from DemiGod");
            Console.WriteLine(panda.SuperPower());

            Console.WriteLine();

            Console.WriteLine("Tiger");
            Tiger tiger = new Tiger();
            Console.WriteLine("from ISleep");
            Console.WriteLine(tiger.Nap());
            Console.WriteLine("from Carnivore");
            Console.WriteLine(tiger.Eat());
            Console.WriteLine("from Animal");
            Console.WriteLine(tiger.Health());
            Console.WriteLine("from DemiGod");
            Console.WriteLine(tiger.SuperPower());

            Console.WriteLine();

            Console.WriteLine("Fox");
            Youkai youkai = new Youkai();
            Console.WriteLine("from Panda");
            Console.WriteLine(youkai.Name());
            Console.WriteLine("from Herbivore");
            Console.WriteLine(youkai.Eat());
            Console.WriteLine("from Animal");
            Console.WriteLine(youkai.Health());
            Console.WriteLine("from DemiGod");
            Console.WriteLine(youkai.SuperPower());
            Console.WriteLine("from IHunt");
            Console.WriteLine(youkai.Weapon());
            Console.WriteLine("from ISleep");
            Console.WriteLine(youkai.Asleep);

            Console.WriteLine();

            Console.WriteLine("Animal");
            Animal animal = new Animal();
            Console.WriteLine("from DemiGod");
            Console.WriteLine(fox.SuperPower());

            Console.WriteLine();

        }
    }
}
