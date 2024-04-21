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
    /// Represents a repository for managing product titles.
    /// </summary>
    public class ProductTitleRepository : Repository<ProductTitle>, IProductTitleRepository
    {
        private readonly DbSet<ProductTitle> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductTitleRepository"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        /// <exception cref="ArgumentNullException">Thrown when the database context is null.</exception>
        public ProductTitleRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "The database context is null");
            }

            dbSet = context.Set<ProductTitle>();
        }
    }
}
