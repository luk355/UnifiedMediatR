using MediatR;

namespace UnifiedMediatR.Eventing
{
    /// <summary>
    /// Marker interface for classes consuming externally raised system events.
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IExternalSystemEventHandler<TEvent> : INotificationHandler<ExternalSystemEvent<TEvent>> where TEvent:ISystemEvent
    {
    }
}