using System;
using MediatR;

namespace UnifiedMediatR.Eventing
{
    public interface IDomainEvent<TAggregateId> : INotification
    {
        /// <summary>
        /// The Aggregate Id of the Aggregate root that the domain concerns.
        /// </summary>
        TAggregateId Id { get; set; }
    }

    public interface IDomainEventHandler<in TEvent, TAggregateId> : INotificationHandler<TEvent> where TEvent : IDomainEvent<TAggregateId>
    {
    }

    public interface IAsyncDomainEvent : IAsyncNotification
    {
    }

    public interface IAsyncDomainEventHandler<in TEvent> : IAsyncNotificationHandler<TEvent> where TEvent : IAsyncDomainEvent
    {
    }
}