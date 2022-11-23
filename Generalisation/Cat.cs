using System;

namespace Inheritance
{

    public class Cat: Mammal
    {
        public string Name ;

        public Cat(string name):base()
        {
            Name = name;
            Console.WriteLine($"I am a cat - {Name}. I inherit mammal.");
        }
    }
}