using System;

namespace DesignPatterns.Src.OOPPrinciples.Composition;

public class Car
{
    public Engine engine { get; set; } = new Engine();
    public Seats seats { get; set; } = new Seats();
    public Wheels wheels { get; set; } = new Wheels();

    public void Details()
    {
        Console.WriteLine($"The car has {this.engine} and has {this.seats} no of seats and has {this.wheels} wheels");
    }

    public void StartTheCar()
    {
        engine.start();
        wheels.Rotate();
    }

}
