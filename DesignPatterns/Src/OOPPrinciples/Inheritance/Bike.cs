using System;

namespace DesignPatterns.Src.OOPPrinciples.Inheritance;

public class Bike : Vehicle
{
    public bool IsEv { get; set; }
    public Bike(string name, string model, bool engine, int wheel, bool ev) : base(name, model, engine, wheel)
    {
        this.IsEv = ev;
    }

    public new void Details()
    {
        Console.WriteLine($"The {this.Name} has {this.HasEngine} and the model of {this.Model} runs on {this.NoOfWheel} and is it EV? {this.IsEv}");
    }
}
