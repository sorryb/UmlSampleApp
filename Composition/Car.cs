using System;

namespace Composition
{

    ///<summary>
    /// Composition: Wheels and engine are 'part of' a car.
    /// If we delete the car the engine and wheels no longer exist.
    ///</summary>
    public class Car
    {
        private Engine _engine ;

        public Car()
        {
            Engine engine = new Engine();
            _engine = engine;
            Console.WriteLine("Car is ready. We have entered inside it.");
        }

        public void Start()
        {
            
            if (_engine != null)
                Console.WriteLine("Because Engine starts the car can go now.");

            Wheel leftFrontWheel = new Wheel("left front");
            Wheel rightFrontWheel = new Wheel("right front");
            Wheel leftrearWheel = new Wheel("left rear");
            Wheel rightRearWheel = new Wheel("right rear");

            if (leftFrontWheel != null &&
                rightFrontWheel != null &&
                leftrearWheel != null &&
                rightRearWheel != null
            )
                Console.WriteLine("All wheels are good. Car is moving. It is composed by engine and four wheels.");


        }

    }
}