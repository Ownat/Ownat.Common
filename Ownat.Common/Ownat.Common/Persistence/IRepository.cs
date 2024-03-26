namespace Ownat.Common.Persistence;

using System.Linq.Expressions;

/// <summary>
    /// Defines a generic repository for managing entities of type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
public interface IRepository<T>
        where T : IEntity
    {
        /// <summary>
        /// Asynchronously creates a new entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to create.</param>
        Task CreateAsync(T entity);

        /// <summary>
        /// Asynchronously retrieves all entities from the repository.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of entities.</returns>
        Task<IReadOnlyCollection<T>> GetAllAsync();

        /// <summary>
        /// Asynchronously retrieves all entities from the repository that satisfy the specified predicate.
        /// </summary>
        /// <param name="filter">A function to test each element for a condition.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains a collection of entities that satisfy the condition specified by <paramref name="filter"/>.</returns>
        Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);

        /// <summary>
        /// Asynchronously retrieves an entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to retrieve.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the entity if found, or null.</returns>
        Task<T> GetAsync(Guid id);

        /// <summary>
        /// Asynchronously retrieves an entity that satisfies the specified predicate.
        /// </summary>
        /// <param name="filter">A function to test the entity for a condition.</param>
        /// <returns>A task that represents the asynchronous operation. The task result contains the entity if found, or null.</returns>
        Task<T> GetAsync(Expression<Func<T, bool>> filter);

        /// <summary>
        /// Asynchronously removes an entity by its identifier.
        /// </summary>
        /// <param name="id">The identifier of the entity to remove.</param>
        Task RemoveAsync(Guid id);

        /// <summary>
        /// Asynchronously updates an entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        Task UpdateAsync(T entity);
    }