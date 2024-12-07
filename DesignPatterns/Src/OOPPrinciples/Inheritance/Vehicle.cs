using System;

namespace DesignPatterns.Src.OOPPrinciples.Inheritance;

public class Vehicle
{
    public bool HasEngine;
    public int NoOfWheel;

    public string? Name;
    public string? Model;

    public Vehicle(string name, string model, bool engine, int wheel)
    {
        this.HasEngine = engine;
        this.Name = name;
        this.NoOfWheel = wheel;
        this.Model = model;
    }

    public void Details()
    {
        Console.WriteLine($"The {this.Name} has {this.HasEngine} and the model of {this.Model} runs on {this.NoOfWheel}");
    }
}
