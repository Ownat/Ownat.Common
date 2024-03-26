namespace Ownat.Common;

using Ownat.Common.Persistence;

public class EntityBase
{
    public Guid Id { get; init; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    protected readonly List<IDomainEvent> _domainEvents = [];

    protected EntityBase(Guid id) => Id = id;

    public List<IDomainEvent> PopDomainEvents()
    {
        var copy = _domainEvents.ToList();

        _domainEvents.Clear();

        return copy;
    }

    protected EntityBase()
    {
    }
}