using StoreBLL.Interfaces;
using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Handlers.ContextMenu
{
    public class GuestContextMenuHandler:ContextMenuHandler
    {
        public GuestContextMenuHandler(ICrud service, Func<AbstractModel> readModel):base(service,readModel)
        {

        }
        public override (ConsoleKey id, string caption, Action action)[] GenerateMenuItems()
        {
            (ConsoleKey id, string caption, Action action)[] array = {
            (ConsoleKey.V,"View Details", this.GetItemDetails)
            };
            return array;
        }
    }
}
