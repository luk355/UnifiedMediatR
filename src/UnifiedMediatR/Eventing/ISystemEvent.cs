using MediatR;

namespace UnifiedMediatR.Eventing
{
    public interface ISystemEvent : INotification
    {
        
    }

    public interface IAsyncSystemEvent : IAsyncNotification
    {
    }

    public interface IAsyncSystemHandler<in TEvent> : IAsyncNotificationHandler<TEvent> where TEvent : IAsyncSystemEvent
    {
    }
}