using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;

namespace StoreDAL.Repository
{
    /// <summary>
    /// Represents a repository for managing products.
    /// </summary>
    public class ProductRepository : AbstractRepository, IProductRepository
    {
        private readonly DbSet<Product> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="context">The store database context.</param>
        public ProductRepository(StoreDbContext context) : base(context)
        {
            dbSet = context.Set<Product>();
        }

        /// <summary>
        /// Adds a new product to the repository.
        /// </summary>
        /// <param name="entity">The product entity to add.</param>
        public void Add(Product entity)
        {
            dbSet.Add(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes a product from the repository.
        /// </summary>
        /// <param name="entity">The product entity to delete.</param>
        public void Delete(Product entity)
        {
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Deletes a product from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        /// <exception cref="InvalidOperationException">Thrown when the product with the specified ID is not found.</exception>
        public void DeleteById(int id)
        {
            var entity = dbSet.Find(id);
            if (entity == null) return;
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        /// <summary>
        /// Gets all products from the repository.
        /// </summary>
        /// <returns>An enumerable collection of all products.</returns>
        public IEnumerable<Product> GetAll() => dbSet.ToList();

        /// <summary>
        /// Gets a paged collection of products from the repository.
        /// </summary>
        /// <param name="pageNumber">The page number.</param>
        /// <param name="rowCount">The number of rows per page.</param>
        /// <returns>An enumerable collection of products for the specified page.</returns>
        /// <exception cref="ArgumentException">Thrown when the page number or row count is less than or equal to zero.</exception>
        public IEnumerable<Product> GetAll(int pageNumber, int rowCount)
        {
            return pageNumber <= 0 || rowCount <= 0
                ? throw new ArgumentException("Page number and row count must be greater than zero")
                : dbSet.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
        }

        /// <summary>
        /// Gets a product by its ID from the repository.
        /// </summary>
        /// <param name="id">The ID of the product to get.</param>
        /// <returns>The product entity with the specified ID.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the product with the specified ID is not found.</exception>
        public Product GetById(int id)
        {
            return dbSet.Find(id) ?? throw new InvalidOperationException("User role with this ID was not found");
        }

        /// <summary>
        /// Updates a product in the repository.
        /// </summary>
        /// <param name="entity">The product entity to update.</param>
        public void Update(Product entity)
        {
            dbSet.Update(entity);
            context.SaveChanges();
        }
    }
}