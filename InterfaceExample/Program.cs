// See https://aka.ms/new-console-template for more information
using InterfaceExample;

INotificationService notificationService = new SmsNotificationService();
notificationService.SendNotification("Hello");

Console.ReadKey();
