using System;
using System.Threading;
using System.Threading.Tasks;

namespace DailyManager.Application.Meditator
{
    public sealed class Sender : ISender
    {
        private readonly IServiceProvider _serviceProvider;

        public Sender(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            var requestType = request.GetType();

            var handlerType = typeof(IRequestHandler<,>).MakeGenericType(requestType, typeof(TResponse));

            var handler = _serviceProvider.GetService(handlerType)
                ?? throw new InvalidOperationException($"Handler for {requestType.Name} not found.");

            var result = await ((dynamic)handler).Handle((dynamic)request, cancellationToken);

            return result;
        }

        public async Task Send(IRequest request, CancellationToken cancellationToken = default)
        {
            var requestType = request.GetType();

            var handlerType = typeof(IRequestHandler<>).MakeGenericType(requestType);

            var handler = _serviceProvider.GetService(handlerType)
                ?? throw new InvalidOperationException($"Handler for {requestType.Name} not found.");

            await ((dynamic)handler).Handle((dynamic)request, cancellationToken);
        }
    }
}
