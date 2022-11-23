using System;

namespace Dependency
{

    public class Pencil
    {
        public string Type ;

        public Pencil(string type)
        {
            Type = type;
            Console.WriteLine($"I am a pencil type - {Type}.");
        }

        public bool Valid => true;
    }
}