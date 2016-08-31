using MediatR;

namespace UnifiedMediatR.Eventing
{
    /// <summary>
    /// Wrapper for SystemEvents to allow internal dispatch without triggerign a re-broadcast.
    /// </summary>
    /// <typeparam name="TSystemEvent"></typeparam>
    public class ExternalSystemEvent<TSystemEvent> : INotification 
    {
        public TSystemEvent Event { get; }

        public ExternalSystemEvent(TSystemEvent systemEvent)
        {
            Event = systemEvent;
        }
    }
}