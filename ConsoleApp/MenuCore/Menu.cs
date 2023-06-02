/*
Yuriy Antonov copyright 2018-2020
*/

namespace ConsoleMenu
{
    public class Menu
    {
        Dictionary<ConsoleKey, MenuItem> items;
        public Menu()
        {
            items = new Dictionary<ConsoleKey, MenuItem>();
        }
        public Menu(ConsoleKey id, string caption, Action action)
        {
            items = new Dictionary<ConsoleKey, MenuItem>();
            items.Add(id,new MenuItem(caption, action));
        }
        
        public Menu((ConsoleKey id, string caption, Action action)[] array)
        {
            items = new Dictionary<ConsoleKey, MenuItem>();
            foreach (var elem in array)
            {
                if (!items.ContainsKey(elem.id))
                {
                    items.Add(elem.id,new MenuItem(elem.caption,elem.action));
                }
            }
        }
        public virtual void Run()
        {
            ConsoleKey resKey;
            bool updateItems = true;
            do
            {
                resKey =RunOnce(ref updateItems);
            } while (resKey != ConsoleKey.Escape);
        }

        public /*virtual*/ ConsoleKey RunOnce(ref bool updateItems)
        {
            ConsoleKeyInfo res;
                if (updateItems)
                {
                    //Console.Clear();
                    foreach (var item in items/*.Values*/)
                    {
                        Console.WriteLine($"<{item.Key}>:  {item.Value}");
                    }
                    Console.WriteLine("Or press <Esc> to return");
                }
                res = Console.ReadKey(true);
                if (items.ContainsKey(res.Key))
                {
                    items[res.Key].Action();
                    updateItems = true;
                }
                else
                {
                    updateItems = false;
                }
            return res.Key;
        }


        public void RunOld()
        {
            ConsoleKeyInfo res;
            bool updateItems = true;
            do
            {
                if (updateItems)
                {
                    //Console.Clear();
                    foreach (var item in items/*.Values*/)
                    {
                        Console.WriteLine($"<{item.Key}>:  {item.Value}");
                    }
                    Console.WriteLine("Or press <Esc> to return");
                }
                res = Console.ReadKey(true);
                if (items.ContainsKey(res.Key))
                {
                    items[res.Key].Action();
                    updateItems = true;
                }
                else
                {
                    updateItems = false;
                }
            } while (res.Key != ConsoleKey.Escape);
        }

    }
}