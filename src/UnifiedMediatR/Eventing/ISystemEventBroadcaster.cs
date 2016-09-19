using MediatR;

namespace UnifiedMediatR.Eventing
{
    /// <summary>
    /// Broadcasts ISystemEvents across the bus.
    /// </summary>
    public interface ISystemEventBroadcaster : INotificationHandler<ISystemEvent>
    {
    }
}
