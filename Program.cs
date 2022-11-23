using System;
using Aggregation;
using Composition;
using Dependency;
using Inheritance;
using Association;

namespace UmlRelations
{
    public class Program
    {
        public static Address address;
        public static Person person;
        public static void Main(string[] args)
        {
            // Aggregation
            address = new Address();
            person = new Person(address);
            
            // Association
            Student student = new Student("John Doe");
            MathClass math = new MathClass();
            math.Teach(student);

            // Composition            
            Car car = new Car();
            car.Start();

            // Dependency
            Pencil pencil = new Pencil("Red crayon");
            Picture picture = new Picture("Painting on Street");
            picture.Valid(pencil);

            // Generalisation
            Dog dog = new Dog();
            Cat cat = new Cat("Tom Cat");
            
        }

 
    }

}


