using MediatR;
using System.Threading.Tasks;

namespace WebApplication1.Message
{
    public interface IMessageMediatorService
    {
        Task<string> Request(string id);
    }

    public class MessageMediatorService : IMessageMediatorService
    {
        private readonly IMediator mediator;

        public MessageMediatorService(IMediator mediator)
        {
            this.mediator = mediator;
        }

        public async Task<string> Request(string id)
        {
            var message = await this.mediator.Send(new Ping(id));
            return message;
        }
    }
}
