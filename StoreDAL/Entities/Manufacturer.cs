using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    // ToDo: add atribute here
    public class Manufacturer : BaseEntity
    {
        // ToDo: add atribute here
        public string Name { get; set; }
        public Manufacturer() : base() { }
        public Manufacturer(int id, string name) : base(id)
        {
            this.Name = name;
        }
    }
}
