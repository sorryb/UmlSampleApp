using System;

namespace Association
{

    public class Student
    {
        public string Name;
        public Student(string name)
        {
            Name = name;
            Console.WriteLine($"I am a student - {Name}");
        }

    }



}