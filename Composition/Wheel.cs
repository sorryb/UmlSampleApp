using System;
namespace Composition
{
public class Wheel
{
    private Wheel()
    {

    }
    
    public Wheel(string location)
    {
        Console.WriteLine($"The {location} wheel is good");
    }

}
}