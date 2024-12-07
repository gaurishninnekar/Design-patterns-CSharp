using System;

namespace DesignPatterns.Src.OOPPrinciples.Polymorphism;

public class Child : Parent
{
    public string School { get; set; }
    public Child(string name, int age, bool dl, string school) : base(name, age, dl)
    {
        this.School = school;
    }

    public override void Drive()
    {
        if (this.Age < 18)
        {
            Console.WriteLine("THe age is less hence cant drive");
        }
    }

}
