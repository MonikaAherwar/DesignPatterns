using BridgePattern.NotificationSystem;
using System;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! We are running design pattern - Bridge Pattern");

            NotificationSystem();
        }

        private static void NotificationSystem()
        {
            // Send Text Message Via SMS, Email, PushNotification
            TextMessage textMessageViaSMS = new TextMessage(new SMS());
            TextMessage textMessageViaEmail = new TextMessage(new Email());
            TextMessage textMessageViaPushNotification = new TextMessage(new PushNotification());
            textMessageViaSMS.SendMessage();
            textMessageViaEmail.SendMessage();
            textMessageViaPushNotification.SendMessage();

            // Send QR Message Via SMS, Email, PushNotification
            QRMessage _QRMessageviaSMS = new QRMessage(new SMS());
            QRMessage _QRMessageViaEmail = new QRMessage(new Email());
            QRMessage _QRMessageViaPushNotification = new QRMessage(new PushNotification());
            _QRMessageviaSMS.SendMessage();
            _QRMessageViaEmail.SendMessage();
            _QRMessageViaPushNotification.SendMessage();
        }
    }
}
