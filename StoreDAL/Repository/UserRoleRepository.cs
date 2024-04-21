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
    public class UserRoleRepository : Repository<UserRole>, IUserRoleRepository
    {
        private readonly DbSet<UserRole> dbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleRepository"/> class.
        /// </summary>
        /// <param name="context">The store database context.</param>
        public UserRoleRepository(StoreDbContext context) : base(context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context), "The database context is null");
            }

            dbSet = context.Set<UserRole>();
        }
    }
}
