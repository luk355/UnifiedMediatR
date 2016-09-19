using System.Threading.Tasks;
using MediatR;
using UnifiedMediatR.Eventing;

namespace UnifiedMediatR.Mediator
{
    public class UnifiedMediator<TAggregateId> : IUnifiedMediator<TAggregateId>
    {
        private readonly IMediator _mediator;

        public UnifiedMediator(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Execute(ICommand command) 
        {
            _mediator.Send(command);
        }

        public TResult Execute<TResult>(ICommand<TResult> command) 
        {
            return _mediator.Send(command);
        }

        public async Task ExecuteAsync(IAsyncCommand command)
        {
            await _mediator.SendAsync(command);
        }

        public void Publish(IDomainEvent<TAggregateId> domainEvent)
        {
            _mediator.Publish(domainEvent);
        }

        public async Task PublishAsync(IAsyncDomainEvent<TAggregateId> domainEvent) 
        {
            await _mediator.PublishAsync(domainEvent);
        }

        public void Publish(ISystemEvent systemEvent)
        {
            _mediator.Publish(systemEvent);
        }

        public async Task PublishAsync(IAsyncSystemEvent systemEvent)
        {
            await _mediator.PublishAsync(systemEvent);
        }

        public TResult Query<TResult>(IQuery<TResult> query)
        {
            return _mediator.Send(query);
        }
    }
}
