using System;

namespace DesignPatterns.Src.OOPPrinciples.Coupling;

public class EmailSender : INotificationService
{

    public void SendNotification(string message)
    {
        //email sending logic

        Console.WriteLine("Sending Email" + message);
    }
}
