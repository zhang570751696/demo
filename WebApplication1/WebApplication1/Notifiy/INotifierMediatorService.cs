using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Notifiy
{
    public interface INotifierMediatorService
    {
        void Notify(string notifyText);
    }

    public class NotifierMediatorService : INotifierMediatorService
    {
        private readonly IMediator _mediator;

        public NotifierMediatorService(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public void Notify(string notifyText)
        {
           this._mediator.Publish(new NotificationMessage(notifyText));
        }
    }
}
