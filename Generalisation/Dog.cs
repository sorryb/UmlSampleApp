using System;

namespace Inheritance
{

    public class Dog: Mammal
    {

        public Dog(): base()
        {
            Console.WriteLine("I am a Dog. I inherit mammal.");
        }
    }
}