using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    [Table("order_states")]
    public class OrderState : BaseEntity
    {
        [Column("state_name")]
        public string StateName {get; set;}
        public virtual IList<CustomerOrder> Order { get; set; }
        public OrderState() : base() { }
        public OrderState(int id,string stateName):base(id)
        {
            this.StateName = stateName;
        }
    }
}
