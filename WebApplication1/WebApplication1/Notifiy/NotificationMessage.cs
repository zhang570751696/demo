using MediatR;

namespace WebApplication1.Notifiy
{
    public class NotificationMessage : INotification
    {
        public string NotifiyText { get; }

        public NotificationMessage(string notifyText)
        {
            this.NotifiyText = notifyText;
        }
    }
}
