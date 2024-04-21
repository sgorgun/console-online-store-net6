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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly DbSet<Product> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="context">The store database context.</param>
        public ProductRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "The database context is null");
            }

            dbSet = context.Set<Product>();
        }
    }
}