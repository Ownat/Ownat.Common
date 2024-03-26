namespace Ownat.Common.Persistence;

public interface IUnitOfWork
{
    Task CommitChangesAsync();
}