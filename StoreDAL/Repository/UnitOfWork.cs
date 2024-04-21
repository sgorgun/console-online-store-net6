using StoreDAL.Data;
using StoreDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Repository
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly StoreDbContext context;
        
        public UnitOfWork(StoreDbContext context)
        {
            this.context = context;
            //Category = new CategoryRepository(context);
            //CustomerOrder = new CustomerOrderRepository(context);
            //Manufacturer = new ManufacturerRepository(context);
            //OderDetail = new OrderDetailRepository(context);
            OrderState = new OrderStateRepository(context);
            Product = new ProductRepository(context);
            User = new UserRepository(context);
            UserRole = new UserRoleRepository(context);
        }
        public ICategoryRepository Category { get; private set; }

        public ICustomerOrderRepository CustomerOrder { get; private set; }

        public IManufacturerRepository Manufacturer { get; private set; }

        public IOrderDetailRepository OderDetail { get; private set; }

        public IOrderStateRepository OrderState { get; private set; }

        public IProductRepository Product { get; private set; }

        public IUserRepository User { get; private set; }

        public IUserRoleRepository UserRole { get; private set; }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
