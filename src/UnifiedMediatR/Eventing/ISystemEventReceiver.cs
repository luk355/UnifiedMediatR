using System.Reflection;

namespace UnifiedMediatR.Eventing
{
    public interface ISystemEventReceiver 
    {
        void Subscribe();
        void Subscribe(string subscriptionId, Assembly[] assemblies);
    }
}