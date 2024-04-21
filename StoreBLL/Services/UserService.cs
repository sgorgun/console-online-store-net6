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
    public class UserService : CrudServiceBase<UserModel, User>
    {
        public UserService(StoreDbContext context)
            : base(new UserRepository(context))
        {
        }

        protected override User ModelToEntity(UserModel model)
        {
            return new User(model.Id, model.UserName, model.LastName, model.Login, model.Password, model.RoleId);
        }

        protected override UserModel EntityToModel(User entity)
        {
            return new UserModel(entity.Id, entity.Name, entity.LastName, entity.Login, entity.Password, entity.RoleId);
        }
    }
}
