using System;

namespace DesignPatterns.Src.OOPPrinciples.Composition;

public class Wheels
{
    public string? Type { get; set; }

    internal void Rotate()
    {
        Console.WriteLine("The wheels have started rotating...");
    }

}
