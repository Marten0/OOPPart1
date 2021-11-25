using System;

namespace OOPCat
{
    class Program
    {
        class Cat
        {
            string name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;
                Console.WriteLine($"The cat {name} with {color} color has been created");
            }
            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return Color; }
            }

            public double Hunger
            {
                get { return hunger; }
            }
            public void Sleep()
            {
                Console.WriteLine("Sleeps");
                hunger += 0.2; //hunger = hunger + 0.2
            }

            public void Meow()
            {
                Console.WriteLine("Meow-meow!");
            }

           
        }
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Kitty", "Orange");

            while (myCat.Hunger != 1)
            {
                myCat.Sleep();
            }

            myCat.Meow();

            Console.WriteLine($"Name: {myCat.Name}");
            Console.WriteLine($"Level of hunger: {myCat.Hunger}");
        }
    }
}
