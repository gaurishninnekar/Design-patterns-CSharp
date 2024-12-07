using System;
using System.Data;



namespace DesignPatterns.Src.OOPPrinciples.Abstraction;

public class EmailService
{
    public void SendEmail()
    {
        Connect();
        Authentication();
        Console.WriteLine("Sending the email...");
        Disconnect();
    }

    private void Connect()
    {
        Console.WriteLine("Connecting to the mail server..");
    }

    private void Authentication()
    {
        Console.WriteLine("Authenticating the user...");
    }

    private void Disconnect()
    {
        Console.WriteLine("Disconnecting from the server...");
    }
}
