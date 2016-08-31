using MediatR;

namespace UnifiedMediatR.Mediator
{
    public interface IQuery<out TResult> : IRequest<TResult> { }
    public interface IQueryHandler<in TQuery, out TResult> : IRequestHandler<TQuery, TResult> where TQuery : IQuery<TResult> { }
}