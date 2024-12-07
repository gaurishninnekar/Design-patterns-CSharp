using System;

namespace DesignPatterns.Src.OOPPrinciples.Polymorphism;

public class Parent
{
    public Parent(string name, int age, bool dl)
    {
        this.Name = name;
        this.Age = age;
        this.HasDL = dl;
    }

    public string? Name { get; set; }
    public int Age { get; set; }

    public bool HasDL { get; set; }


    public virtual void Drive()
    {
        if (this.HasDL)
        {
            Console.WriteLine($"The parent {this.Name} is of age {this.Age} has DL? {this.HasDL}. Alright...Driving the car");
        }
    }
}
