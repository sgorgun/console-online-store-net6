using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Controllers;
using ConsoleApp.Handlers.ContextMenu;
using ConsoleApp1;
using StoreBLL.Interfaces;
using StoreBLL.Models;

namespace ConsoleMenu
{
    public class ContextMenu:Menu
    {
        private Func<IEnumerable<AbstractModel>> getAll;
        public ContextMenu(AdminContextMenuHandler controller, Func<IEnumerable<AbstractModel>> getAll) :base(controller.GenerateMenuItems())
        {
            this.getAll = getAll;
        }
        public ContextMenu(Func<(ConsoleKey id, string caption, Action action)[]> GenerateMenuItems, Func<IEnumerable<AbstractModel>> getAll):base(GenerateMenuItems())
        {
            this.getAll = getAll;
        }

        public override void Run()
        {
            ConsoleKey resKey;
            bool updateItems = true;
            do
            {
                if (updateItems)
                {
                    Console.WriteLine("======= Current DataSet ==========");
                    foreach (var record in getAll())
                    {
                        Console.WriteLine(record);
                    }
                    Console.WriteLine("===================================");
                }
                resKey = RunOnce(ref updateItems);
            } while (resKey != ConsoleKey.Escape);
        }



    }
}
