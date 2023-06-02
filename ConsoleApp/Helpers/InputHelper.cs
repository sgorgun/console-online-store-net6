using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Helpers
{
    internal static class InputHelper
    {
        public static CategoryModel ReadCategoryiModel()
        {
            throw new NotImplementedException();
        }

        public static ManufacturerModel ReadManufacturerModel()
        {
            throw new NotImplementedException();
        }

        public static OrderStateModel ReadOrderStateModel()
        {
            Console.WriteLine("Input State Id");
            var id=int.Parse(Console.ReadLine());
            Console.WriteLine("Input State Name");
            var name = Console.ReadLine();
            return new OrderStateModel(id,name);
            //throw new NotImplementedException();
        }

        public static UserRoleModel ReadUserRoleModel()
        {
            Console.WriteLine("Input User Role Id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Input User Role Name");
            var name = Console.ReadLine();
            return new UserRoleModel(id, name);
            //throw new NotImplementedException();
        }
    }
}
