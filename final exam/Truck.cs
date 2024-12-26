using System;
public class Truck 
{
    public int CargoCapacity {get; set;}
    public virtual void Start()
    {
        Console.WriteLine("The truck's heavy engine rumbles as it starts!");
    }
}
