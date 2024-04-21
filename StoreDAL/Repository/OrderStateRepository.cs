using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Repository
{
    /// <summary>
    /// Represents a repository for managing order states.
    /// </summary>
    public class OrderStateRepository : AbstractRepository, IOrderStateRepository
    {
        private readonly DbSet<OrderState> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderStateRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        /// <exception cref="ArgumentNullException">Thrown when the database context is null.</exception>
        public OrderStateRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "The database context is null");
            }

            dbSet = context.Set<OrderState>();
        }

        /// <summary>
        /// Adds a new order state to the repository.
        /// </summary>
        /// <param name="entity">The order state to add.</param>
        public void Add(OrderState entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes an order state from the repository.
        /// </summary>
        /// <param name="entity">The order state to delete.</param>
        public void Delete(OrderState entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an order state by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the order state to delete.</param>
        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Gets all order states from the repository.
        /// </summary>
        /// <returns>An enumerable collection of order states.</returns>
        public IEnumerable<OrderState> GetAll()
        {
            return dbSet.ToList();
        }

        /// <summary>
        /// Gets a paged list of order states from the repository.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="rowCount">The number of rows per page.</param>
        /// <returns>An enumerable collection of order states.</returns>
        /// <exception cref="ArgumentException">Thrown when the page number or row count is less than or equal to zero.</exception>
        public IEnumerable<OrderState> GetAll(int pageNumber, int rowCount)
        {
            return pageNumber <= 0 || rowCount <= 0
                ? throw new ArgumentException("Page number and row count must be greater than zero")
                : dbSet.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        /// <summary>
        /// Gets an order state by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the order state.</param>
        /// <returns>The order state with the specified ID.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the order state with the specified ID is not found.</exception>
        public OrderState GetById(int id)
        {
            return dbSet.Find(id) ?? throw new InvalidOperationException("Product title with this ID was not found");
        }

        /// <summary>
        /// Updates an order state in the repository.
        /// </summary>
        /// <param name="entity">The order state to update.</param>
        public void Update(OrderState entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
