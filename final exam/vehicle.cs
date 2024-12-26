using System;
public class Vehicle{
    public string Name {get; set;}
    private int Speed {get; set;}

    public static int TotalVehicles;

    public Vehicle(string Name, int Speed)
    {
        this.Name = Name;
        this.Speed = Speed;
    }
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting!");
    }
    public void Accelerate(int increment)
    {
        Speed++;
        Console.WriteLine(Speed);
    }
    public int GetSpeed()
    {
        return Speed;
    }
}