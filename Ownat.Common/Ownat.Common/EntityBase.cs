namespace Ownat.Common;

using Ownat.Common.Persistence;

/// <summary>
/// Represents the base class for all entities in the application.
/// </summary>
public class EntityBase
{
    /// <summary>
    /// Gets the unique identifier for the entity.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Gets or sets the unique identifier of the user who created the entity.
    /// </summary>
    public Guid CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date and time the entity was created.
    /// </summary>
    public DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the user who last updated the entity.
    /// </summary>
    public Guid LastUpdatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date and time the entity was last updated.
    /// </summary>
    public DateTime? LastUpdatedAt { get; set; }

    /// <summary>
    /// Holds the domain events that have occurred within the entity.
    /// </summary>
    protected readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();

    /// <summary>
    /// Initializes a new instance of the <see cref="EntityBase"/> class with the specified identifier.
    /// </summary>
    /// <param name="id">The unique identifier for the entity.</param>
    protected EntityBase(Guid id) => Id = id;

    /// <summary>
    /// Retrieves and removes all domain events from the entity.
    /// </summary>
    /// <returns>A list of domain events.</returns>
    public List<IDomainEvent> PopDomainEvents()
    {
        var copy = _domainEvents.ToList();

        _domainEvents.Clear();

        return copy;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EntityBase"/> class.
    /// </summary>
    protected EntityBase()
    {
    }
}