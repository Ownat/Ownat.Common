namespace Ownat.Common.Persistence;

/// <summary>
/// Defines a basic entity with common properties.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Gets or sets the unique identifier for the entity.
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the date and time the entity was created.
    /// </summary>
    DateTime CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the date and time the entity was last updated.
    /// </summary>
    DateTime UpdatedAt { get; set; }
}