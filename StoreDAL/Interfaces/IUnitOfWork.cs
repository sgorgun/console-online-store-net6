using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICustomerOrderRepository CustomerOrder { get; }
        IManufacturerRepository Manufacturer { get; }
        IOrderDetailRepository OderDetail { get; }
        IOrderStateRepository OrderState { get; }
        IProductRepository Product { get; }
        IUserRepository User { get; }
        IUserRoleRepository UserRole { get; }

        int Complete();
    }
}
