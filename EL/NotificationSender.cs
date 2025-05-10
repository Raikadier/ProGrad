using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EL
{
    internal class NotificationSender
    {
        private int idNotification {  get; set; } 
        private string notificationMessage { get; set; } 
        private string notificationDateSent { get; set; }
        private string notificationStatus { get; set; }
        private string notificationType { get; set; }

        private User user { get; set; }

        public NotificationSender() { }

        public NotificationSender(int idNotification, string notificationMessage, string notificationDateSent, string notificationStatus, string notificationType)
        {
            this.idNotification = idNotification;
            this.notificationMessage = notificationMessage;
            this.notificationDateSent = notificationDateSent;
            this.notificationStatus = notificationStatus;
            this.notificationType = notificationType;
        }

        public void sendNotification(User user) { }

        public override string ToString()
        {
            return base.ToString() + $"{idNotification};{notificationDateSent};{notificationMessage};{notificationStatus};{notificationType}";
        }
    }
}
