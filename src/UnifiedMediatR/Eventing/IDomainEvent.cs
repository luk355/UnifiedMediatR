using System;
using MediatR;

namespace UnifiedMediatR.Eventing
{
    public interface IDomainEvent<out TAggregateId> : INotification
    {
        /// <summary>
        /// The Aggregate Id of the Aggregate root that the domain concerns.
        /// </summary>
        TAggregateId Id { get; }
    }

    public interface IDomainEventHandler<in TEvent, TAggregateId> : INotificationHandler<TEvent> where TEvent : IDomainEvent<TAggregateId>
    {
    }

    public interface IAsyncDomainEvent<out TAggregateId> : IAsyncNotification
    {
        /// <summary>
        /// The Aggregate Id of the Aggregate root that the domain concerns.
        /// </summary>
        TAggregateId Id { get; }
    }

    public interface IAsyncDomainEventHandler<in TEvent, TAgrregateId> : IAsyncNotificationHandler<TEvent> where TEvent : IAsyncDomainEvent<TAgrregateId>
    {
    }
}