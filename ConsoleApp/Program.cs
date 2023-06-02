using System;
using System.Linq;
using ConsoleMenu;
using StoreDAL.Data;

using Microsoft.Data.Sqlite;
using StoreDAL.Data.InitDataFactory;
using StoreDAL.Entities;
//using static Humanizer.In;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ConsoleApp1
{
    class Program
    {
        //TODO: todo
        static void Main(string[] args)
        {
            //Menu menu= new Menu(ConsoleKey.F1, "About", ()=>{ Console.WriteLine("About with app"); });
            //menu.Run();
            //var factory = new StoreDbFactory(new TestDataFactory());
            //var context =factory.CreateContext();
            UserMenuController.Start();

            //AbstractDataFactory dataFactory = new TestDataFactory();
            //var count = context.OrderStates.Count();
            //Console.WriteLine(count);
            //var con=context.OrderStates.ToArray();
            //Console.WriteLine(con);
        }
    }
}
