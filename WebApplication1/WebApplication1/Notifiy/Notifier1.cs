using MediatR;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication1.Notifiy
{
    public class Notifier1 : INotificationHandler<NotificationMessage>
    {
        public async Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Debugging from Notifier 1. Message : {notification.NotifiyText}");
        }
    }

    public class Notifier2 : INotificationHandler<NotificationMessage>
    {
        public async Task Handle(NotificationMessage notification, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Debugging from Notifier 2. Message : {notification.NotifiyText}");
        }
    }
}
