using MediatR;

namespace WebApplication1.Message
{
    public class Ping : IRequest<string>
    {
        public string Id { get; }

        public Ping(string id)
        {
            this.Id = id;
        }
    }
}
