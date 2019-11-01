using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WebApplication1.Message
{
    public class PingHandler : IRequestHandler<Ping, string>
    {
        public async Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return request.Id;
        }
    }
}
