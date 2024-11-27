using System;

abstract class Vehicle
{
    public abstract void Move();
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving.");
    }
}

class Bicycle : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Bicycle is moving.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car();
        car.Move();

        Vehicle bicycle = new Bicycle();
        bicycle.Move();
        Console.ReadKey();
    }
}
