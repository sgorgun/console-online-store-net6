using Microsoft.EntityFrameworkCore;
using StoreDAL.Data;
using StoreDAL.Entities;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
{
    private readonly DbSet<TEntity> dbSet;
    private readonly StoreDbContext context;

    public Repository(StoreDbContext context)
    {
        this.context = context ?? throw new ArgumentNullException(nameof(context), "The database context is null");
        dbSet = context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        dbSet.Add(entity);
        context.SaveChanges();
    }

    public void Delete(TEntity entity)
    {
        dbSet.Remove(entity);
        context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var entity = dbSet.Find(id);
        if (entity == null) return;
        dbSet.Remove(entity);
        context.SaveChanges();
    }

    public IEnumerable<TEntity> GetAll()
    {
        return dbSet.ToList();
    }

    public IEnumerable<TEntity> GetAll(int pageNumber, int rowCount)
    {
        return pageNumber <= 0 || rowCount <= 0
            ? throw new ArgumentException("Page number and row count must be greater than zero")
            : dbSet.Skip((pageNumber - 1) * rowCount).Take(rowCount).ToList();
    }

    public TEntity GetById(int id)
    {
        return dbSet.Find(id) ?? throw new InvalidOperationException("Product title with this ID was not found");
    }

    public void Update(TEntity entity)
    {
        dbSet.Update(entity);
        context.SaveChanges();
    }
}
