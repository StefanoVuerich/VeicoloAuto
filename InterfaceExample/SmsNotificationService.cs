namespace InterfaceExample
{
    using System;

    public class SmsNotificationService : INotificationService
    {
        public void SendNotification(string text)
        {
            Console.WriteLine("Sending " + text + " via sms");
        }
    }
}
