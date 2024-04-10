using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    [Table("manufacturers")]
    public class Manufacturer : BaseEntity
    {
        [Column("manufacturer_name")]
        public string Name { get; set; }
        public Manufacturer() : base() { }
        public Manufacturer(int id, string name) : base(id)
        {
            this.Name = name;
        }
    }
}
