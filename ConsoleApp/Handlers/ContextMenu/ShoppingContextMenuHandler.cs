using StoreBLL.Interfaces;
using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Handlers.ContextMenu
{
    public class ShoppingContextMenuHandler : ContextMenuHandler
    {
        public ShoppingContextMenuHandler(ICrud service, Func<AbstractModel> readModel):base(service,readModel)
        {
        }

        public void CreateOrder()
        {
            //ToDO
            throw new NotImplementedException();
        }

        public override (ConsoleKey id, string caption, Action action)[] GenerateMenuItems()
        {
            (ConsoleKey id, string caption, Action action)[] array = {
             (ConsoleKey.V,"View Details", this.GetItemDetails)
            ,(ConsoleKey.A,"Add item to chart and create order", this.CreateOrder)
            };
            return array;
        }
    }
}
