using System;

namespace Association
{

// We do not keep track of student in a field from class
    public class MathClass
    {
        public string Name => "Math";
        public MathClass()
        {

        }

        public void Teach(Student student)
        {
            Console.WriteLine($"On {Name} class we teach {student.Name} associated student.");

        }

    }



}