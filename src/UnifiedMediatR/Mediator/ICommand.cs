using MediatR;

namespace UnifiedMediatR.Mediator
{
    public interface ICommand : IRequest<Unit>
    {
    }

    public interface IAsyncCommand : IAsyncRequest<Unit>
    {
    }

    public interface ICommand<out TResult> : IRequest<TResult>
    {
    }

    public interface IAsyncCommand<out TResult> : IAsyncRequest<TResult>
    {
    }

    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Unit> where TCommand : ICommand
    {
    }

    public interface ICommandHandler<in TCommand, out TResult> : IRequestHandler<TCommand, TResult> where TCommand : ICommand<TResult>
    {
    }

    public interface IAsyncCommandHandler<in TCommand, TResult> : IAsyncRequestHandler<TCommand, TResult> where TCommand : IAsyncCommand<TResult>
    {
    }

    public interface IAsyncCommandHandler<in TCommand> : IAsyncRequestHandler<TCommand, Unit> where TCommand : IAsyncCommand
    {
    }
}
