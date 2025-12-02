
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Notification
{
    class EmailNotificationService : INotificationService
    {
        public EmailNotificationService()
        {

        }

        public void SendNotification(string recipient, string msg)
        {
            Console.WriteLine($"Email: \n To: {recipient}\n {msg}");
        }
    }
}
