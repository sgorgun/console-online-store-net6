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
    /// Represents a repository for managing user roles.
    /// </summary>
    public class UserRoleRepository : AbstractRepository, IUserRoleRepository
    {
        private readonly DbSet<UserRole> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleRepository"/> class.
        /// </summary>
        /// <param name="context">The store database context.</param>
        public UserRoleRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<UserRole>();
        }

        /// <summary>
        /// Adds a new user role to the repository.
        /// </summary>
        /// <param name="entity">The user role entity to add.</param>
        public void Add(UserRole entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes a user role from the repository.
        /// </summary>
        /// <param name="entity">The user role entity to delete.</param>
        public void Delete(UserRole entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a user role by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the user role to delete.</param>
        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity == null) return;
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all user roles from the repository.
        /// </summary>
        /// <returns>An enumerable collection of user roles.</returns>
        public IEnumerable<UserRole> GetAll()
        {
            return dbSet.ToList();
        }

        /// <summary>
        /// Gets a paged list of user roles from the repository.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="rowCount">The number of rows per page.</param>
        /// <returns>An enumerable collection of user roles.</returns>
        /// <exception cref="ArgumentException">Thrown when the page number or row count is less than or equal to zero.</exception>
        public IEnumerable<UserRole> GetAll(int pageNumber, int rowCount)
        {
            return pageNumber <= 0 || rowCount <= 0
                ? throw new ArgumentException("Page number and row count must be greater than zero")
                : dbSet.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        /// <summary>
        /// Gets a user role by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the user role to get.</param>
        /// <returns>The user role entity.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the user role with the specified ID is not found.</exception>
        public UserRole GetById(int id)
        {
            return dbSet.Find(id) ?? throw new InvalidOperationException("User role with this ID was not found");
        }

        /// <summary>
        /// Updates a user role in the repository.
        /// </summary>
        /// <param name="entity">The user role entity to update.</param>
        public void Update(UserRole entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}
