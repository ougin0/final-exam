using System;

public class Program
{
    public void Main(Car car)
    {
        int[] Vehicle = new int[3];
        for (int i=0; i < 3 ;)
        {

            Car Car = new Car();
            Car.Start();
        
            Motorcycle Motorcycle = new Motorcycle();
            Motorcycle.Start();

            Truck Truck = new Truck();
            Truck.Start();

        }
    }
}