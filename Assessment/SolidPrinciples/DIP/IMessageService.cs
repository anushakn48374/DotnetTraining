using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface IMessageService
    {
        void SendMessage(string message);
    }

    // Step 2: Implement the abstraction in low-level modules
    public class EmailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending Email: {message}");
        }
    }

    public class SMSService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    // Step 3: Use the abstraction in the high-level module
    public class NotificationManager
    {
        private readonly IMessageService _messageService;

        public NotificationManager(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }
    }
}
