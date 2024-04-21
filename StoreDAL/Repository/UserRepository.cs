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
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly DbSet<User> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="context">The store database context.</param>
        public UserRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "The database context is null");
            }

            dbSet = context.Set<User>();
        }
    }
}
