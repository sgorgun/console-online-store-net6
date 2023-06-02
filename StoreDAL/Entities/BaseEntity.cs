using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Entities
{
    public abstract class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }
        protected BaseEntity(int id)
        { this.Id = id; }
        protected BaseEntity()
        { this.Id = 0; }
    }
}
