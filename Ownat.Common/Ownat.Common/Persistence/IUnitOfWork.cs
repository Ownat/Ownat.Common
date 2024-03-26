namespace Ownat.Common.Persistence;

/// <summary>
/// Defines a unit of work, which is a way to group one or more operations (like insert, update, delete) into a single transaction.
/// </summary>
public interface IUnitOfWork
{
    /// <summary>
    /// Commits all changes made in this unit of work to the database asynchronously.
    /// </summary>
    Task CommitChangesAsync();
}