using StoreBLL.Interfaces;
using StoreBLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Handlers.ContextMenu
{
    public abstract class ContextMenuHandler
    {
        protected readonly ICrud service;
        protected readonly Func<AbstractModel> readModel;

        protected ContextMenuHandler(ICrud service, Func<AbstractModel> readModel)
        {
            this.service = service;
            this.readModel = readModel;
        }

        public void GetItemDetails()
        {
            Console.WriteLine("Input record ID for more details");
            int Id = int.Parse(Console.ReadLine());
            Console.WriteLine(service.GetById(Id));
        }

        public abstract (ConsoleKey id, string caption, Action action)[] GenerateMenuItems();
    }
}
