/*
Yuriy Antonov copyright 2018-2020
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMenu
{
    public class MenuItem
    {
        private readonly string caption;
        private readonly Action action;
        public string Caption { get { return caption; } }
        public Action Action{ get { return action; } }
        public MenuItem(string caption, Action action)
        {
            this.caption = caption;
            this.action = action;
        }
        public override string ToString()
        {
            return caption;
        }
    }

}
