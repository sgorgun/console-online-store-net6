using System;
using System.Collections.Generic;


namespace StoreBLL.Models
{
    public class OrderStateModel : AbstractModel
    {
        public string StateName { get; set; }
        public OrderStateModel(int id,string stateName):base(id)
        {
            this.Id = id;
            this.StateName = stateName;
        }
        public override string ToString()
        {
            return $"Id:{Id} {StateName}";
        }
    }
}
