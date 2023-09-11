using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.NotificationSystem
{
    internal class PushNotification : INotificationSender
    {
        void INotificationSender.SendNotification()
        {
            Console.WriteLine("Message is sent via Push Notification");
        }
    }
}
