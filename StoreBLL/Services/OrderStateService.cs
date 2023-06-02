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
    public class OrderStateService : ICrud
    {
        IOrderStateRepository repository;
        public OrderStateService(StoreDbContext context)
        {
            repository = new OrderStateRepository(context);
        }
        public void Add(AbstractModel model)
        {
            var x = (OrderStateModel)model;
            repository.Add(new OrderState(x.Id,x.StateName));
        }
        public void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }
        public IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(x => new UserRoleModel(x.Id, x.StateName));
        }
        public AbstractModel GetById(int id)
        {
            var res = repository.GetById(id);
            return new OrderStateModel(res.Id, res.StateName);
        }
        public void Update(AbstractModel model)
        {
            throw new NotImplementedException();
        }
    }
}
