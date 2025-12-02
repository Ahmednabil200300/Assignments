using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Notification
{
    class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string msg)
        {
            Console.WriteLine($"Push Notification\n {recipient}\n {msg}");
        }
    }
}
