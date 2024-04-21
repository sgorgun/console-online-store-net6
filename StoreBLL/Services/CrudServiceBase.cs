using StoreBLL.Interfaces;
using StoreBLL.Models;
using StoreDAL.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace StoreBLL.Services
{
    public abstract class CrudServiceBase<TModel, TEntity> : ICrud
            where TModel : AbstractModel
            where TEntity : StoreDAL.Entities.BaseEntity
    {
        private readonly IRepository<TEntity> repository;

        protected CrudServiceBase(IRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public virtual void Add(AbstractModel model)
        {
            var entity = ModelToEntity((TModel)model);
            repository.Add(entity);
        }

        public virtual void Delete(int modelId)
        {
            repository.DeleteById(modelId);
        }

        public virtual IEnumerable<AbstractModel> GetAll()
        {
            return repository.GetAll().Select(EntityToModel);
        }

        public virtual AbstractModel GetById(int id)
        {
            var entity = repository.GetById(id);
            return EntityToModel(entity);
        }

        public virtual void Update(AbstractModel model)
        {
            var entity = ModelToEntity((TModel)model);
            repository.Update(entity);
        }

        protected abstract TEntity ModelToEntity(TModel model);
        protected abstract TModel EntityToModel(TEntity entity);
    }
}
