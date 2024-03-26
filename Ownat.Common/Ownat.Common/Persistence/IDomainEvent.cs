namespace Ownat.Common.Persistence;

using MediatR;

/// <summary>
/// Defines a domain event, which is a notification that something domain-specific has occurred.
/// </summary>
/// <remarks>
/// A domain event is a way of communicating that something interesting has happened in the domain.
/// Other parts of the application can subscribe to these events and react accordingly.
/// This interface is derived from the <see cref="INotification"/> interface from the MediatR library,
/// which provides a simple, unidirectional messaging system.
/// </remarks>
public interface IDomainEvent : INotification;