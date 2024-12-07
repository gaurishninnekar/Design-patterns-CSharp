using System;

namespace DesignPatterns.Src.OOPPrinciples.Coupling;

public class Order
{
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    public void PlaceOrder()
    {
        //place order logic

        notificationService.SendNotification("Order placed successfully");
    }
}
