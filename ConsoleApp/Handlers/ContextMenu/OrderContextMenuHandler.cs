using StoreBLL.Interfaces;
using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Handlers.ContextMenu
{
    public class OrderContextMenuHandler : ContextMenuHandler
    {
        public OrderContextMenuHandler(ICrud service, Func<AbstractModel> readModel):base(service,readModel)
        {
        }

        public void RemoveItem()
        {
            Console.WriteLine("Input record ID that will be removed");
            int Id = int.Parse(Console.ReadLine());
            service.Delete(Id);
        }

        public void EditItem()
        {
            Console.WriteLine("Input record ID that will be edited");
            int Id = int.Parse(Console.ReadLine());
            var record=readModel();
            //TODO
            service.Update(record);
        }

        public override (ConsoleKey id, string caption, Action action)[] GenerateMenuItems()
        {
            (ConsoleKey id, string caption, Action action)[] array = {
             (ConsoleKey.V,"View Details", this.GetItemDetails)
            ,(ConsoleKey.V,"Change order status", this.EditItem)
            };
            return array;
        }
    }
}
