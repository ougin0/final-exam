using System;
public class Car 
{
    public int FuelEfficiency {get; set;}
    public virtual void Start()
    {
        Console.WriteLine("The car is starting with a smooth engine sound!");
    }
}
