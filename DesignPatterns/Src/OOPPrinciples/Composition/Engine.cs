using System;

namespace DesignPatterns.Src.OOPPrinciples.Composition;

public class Engine
{
    public int CC { get; set; }
    public decimal HorsePower { get; set; }

    internal void start()
    {
        Console.WriteLine("The Engine has started...");
    }
}
