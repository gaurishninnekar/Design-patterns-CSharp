using System;

namespace DesignPatterns.Src.OOPPrinciples.Coupling;

public class SMSService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("SMS Message: Sending a sms");
    }
}
