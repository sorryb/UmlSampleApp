using System;

namespace Dependency
{

    public class Picture
    {
        public string Name ;

        public Picture(string name)
        {
            Name = name;
            Console.WriteLine($"I am a graphic with name - {Name}.");
        }
        public bool Valid(Pencil pencil)
        {
            Console.WriteLine($"I am valid it depends if the pencil {pencil.Type} is valid");
            return pencil.Valid;
        }
    }
}