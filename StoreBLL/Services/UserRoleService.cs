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
    public class UserRoleService : ICrud
    {
        IUserRoleRepository repository;
        public UserRoleService(StoreDbContext context)
        {
            repository = new UserRoleRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var x = (UserRoleModel)model;
            repository.Add(new UserRole(x.Id, x.RoleName));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x=>new UserRoleModel(x.Id,x.RoleName));
            throw new NotImplementedException();
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new UserRoleModel(res.Id, res.RoleName);
        }
        public void Update(AbstractModel model)
        {
            throw new NotImplementedException();
        }
    }
}
