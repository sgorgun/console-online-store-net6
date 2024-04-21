using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using StoreDAL.Repository;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBLL.Services
{
    public class UserRoleService : CrudServiceBase<UserRoleModel, UserRole>
    {
        public UserRoleService(StoreDbContext context)
            : base(new UserRoleRepository(context))
        {
        }

        protected override UserRole ModelToEntity(UserRoleModel model)
        {
            return new UserRole(model.Id, model.RoleName);
        }

        protected override UserRoleModel EntityToModel(UserRole entity)
        {
            return new UserRoleModel(entity.Id, entity.RoleName);
        }
    }

}
