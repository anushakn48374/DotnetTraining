using DIP;

class Program
{
    static void Main(string[] args)
    {
        IMessageService emailService = new EmailService();
        IMessageService smsService = new SMSService();

        NotificationManager emailNotification = new NotificationManager(emailService);
        emailNotification.Notify("Hello via Email!");

        NotificationManager smsNotification = new NotificationManager(smsService);
        smsNotification.Notify("Hello via SMS!");
    }
}