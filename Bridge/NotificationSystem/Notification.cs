using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.NotificationSystem
{
    internal abstract class Notification
    {
        internal INotificationSender notificationSender;
        public Notification(INotificationSender notificationSender) 
        {
            this.notificationSender = notificationSender;
        }

        public abstract void SendMessage();
    }
}
