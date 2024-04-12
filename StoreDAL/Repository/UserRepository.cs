using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreDAL.Data;
using Microsoft.EntityFrameworkCore;

namespace StoreDAL.Repository
{
    /// <summary>
    /// Represents a repository for managing users.
    /// </summary>
    public class UserRepository : AbstractRepository, IUserRepository
    {
        private readonly DbSet<User> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="context">The store database context.</param>
        public UserRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<User>();
        }

        /// <summary>
        /// Adds a new user to the repository.
        /// </summary>
        /// <param name="entity">The user entity to add.</param>
        public void Add(User entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes a user from the repository.
        /// </summary>
        /// <param name="entity">The user entity to delete.</param>
        public void Delete(User entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes a user by ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        /// <exception cref="InvalidOperationException">Thrown when the user with the specified ID is not found.</exception>
        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity == null) return;
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all users from the repository.
        /// </summary>
        /// <returns>An enumerable collection of users.</returns>
        public IEnumerable<User> GetAll() => dbSet.ToList();

        /// <summary>
        /// Gets a paged list of users from the repository.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="rowCount">The number of rows per page.</param>
        /// <returns>An enumerable collection of users.</returns>
        /// <exception cref="ArgumentException">Thrown when the page number or row count is less than or equal to zero.</exception>
        public IEnumerable<User> GetAll(int pageNumber, int rowCount)
        {
            return pageNumber <= 0 || rowCount <= 0
                ? throw new ArgumentException("Page number and row count must be greater than zero")
                : dbSet.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        /// <summary>
        /// Gets a user by ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the user to get.</param>
        /// <returns>The user entity.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the user with the specified ID is not found.</exception>
        public User GetById(int id)
        {
            return dbSet.Find(id) ?? throw new InvalidOperationException("User role with this ID was not found");
        }

        /// <summary>
        /// Updates a user in the repository.
        /// </summary>
        /// <param name="entity">The user entity to update.</param>
        public void Update(User entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
