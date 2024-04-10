using StoreDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Data.InitDataFactory
{
    public class TestDataFactory : AbstractDataFactory
    {
        public override Category[] GetCategoryData()
        {
            return new[]
            {
                new Category(1,"fruits"),
                new Category(2,"water"),
                new Category(3,"vegetables"),
                new Category(4,"seafood"),
                new Category(5,"meet"),
                new Category(6,"grocery"),
                new Category(7,"milk food"),
                new Category(8,"smartphones"),
                new Category(9,"laptop"),
                new Category(10,"photocameras"),
                new Category(11,"kitchen accesories"),
                new Category(12,"spices"),
                new Category(13,"Juice"),
                new Category(14,"alcohol drinks"),
            };
        }
        public override CustomerOrder[] GetCustomerOrderData()
        {
            return Array.Empty<CustomerOrder>();
        }

        public override Manufacturer[] GetManufacturerData()
        {
            return new[]
            {
                new Manufacturer(1, "Manufacturer 1"),
                new Manufacturer(2, "Manufacturer 2"),
                new Manufacturer(3, "Manufacturer 3"),
            };
        }
        public override OrderDetail[] GetOrderDetailData()
        {
            return new[]
            {
                new OrderDetail(1, 1, 1, 2, 20),
                new OrderDetail(2, 2, 2, 3, 60),
                new OrderDetail(3, 3, 3, 1, 10),
            };
        }

        public override OrderState[] GetOrderStateData()
        {
            return new[]
            {
                new OrderState(1,"New Order"),
                new OrderState(2,"Cancelled by user"),
                new OrderState(3,"Cancelled by administrator"),
                new OrderState(4,"Confirmed"),
                new OrderState(5,"Moved to delivery company"),
                new OrderState(6,"In delivery"),
                new OrderState(7,"Delivered to client"),
                new OrderState(8,"Delivery confirmed by client")
            };
        }
        public override Product[] GetProductData()
        {
            return new[]
            {
                new Product(1, 1, 1, "Product 1 description", 10.0m),
                new Product(2, 2, 2, "Product 2 description", 20.0m),
                new Product(3, 3, 3, "Product 3 description", 30.0m),
            };
        }
        public override ProductTitle[] GetProductTitleData()
        {
            return new[]
            {
                new ProductTitle(1, "Product Title 1", 1),
                new ProductTitle(2, "Product Title 2", 2),
                new ProductTitle(3, "Product Title 3", 3),
            };
        }
        public override User[] GetUserData()
        {
            return new[]
            {
                new User(1, "User 1", "user1@example.com", "login1", "password1", 1),
                new User(2, "User 2", "user2@example.com"," login2", "password2", 2),
                new User(3, "User 3", "user3@example.com", "login3", "password3", 3),
            };
        }
        public override UserRole[] GetUserRoleData()
        {
            return new[]
            {
                new UserRole(1,"Admin"),
                new UserRole(2,"Registered"),
                new UserRole(3,"Guest"),
            };
        }
    }
}
