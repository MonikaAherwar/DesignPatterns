using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.NotificationSystem
{
    internal class QRMessage : Notification
    {
        public QRMessage(INotificationSender notificationSender) : base(notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        public override void SendMessage()
        {
            Console.WriteLine("QR Message is Sent");
            notificationSender.SendNotification();
            
        }
    }
}
