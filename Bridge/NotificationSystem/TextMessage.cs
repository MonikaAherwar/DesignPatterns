using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.NotificationSystem
{
    internal class TextMessage : Notification
    {
        public TextMessage(INotificationSender notificationSender) : base(notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        public override void SendMessage()
        {
            Console.WriteLine("Text Message is Sent");
            notificationSender.SendNotification();
            
        }
    }
}
