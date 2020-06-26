using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data
{
    /// <summary>
    /// Interface that represents a client connection.
    /// </summary>
    public interface IClient : IDisposable
    {
        /// <summary>
        /// Gets an item with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <typeparam name="T">The item type.</typeparam>
        /// <returns>The item.</returns>
        Task<T> Get<T>(Guid id)
            where T : Dto;

        /// <summary>
        /// Gets all items of the specified type.
        /// </summary>
        /// <typeparam name="T">The item type.</typeparam>
        /// <returns>The items.</returns>
        Task<IEnumerable<T>> GetAll<T>()
            where T : Dto;

        /// <summary>
        /// Posts the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <typeparam name="T">The entity type.</typeparam>
        /// <returns>The return entity.</returns>
        Task<T> Post<T>(T entity)
            where T : Dto;

        /// <summary>
        /// Delete the specified entity.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <typeparam name="T">The entity type.</typeparam>
        /// <returns>A completion notification.</returns>
        Task Delete<T>(Guid id)
            where T : Dto;

        /// <summary>
        /// Delete the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <typeparam name="T">The entity type.</typeparam>
        /// <returns>A completion notification.</returns>
        Task Delete<T>(T entity)
            where T : Dto;
    }
}