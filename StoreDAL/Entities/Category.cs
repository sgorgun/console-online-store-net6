using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    [Table("categories")]
    public class Category : BaseEntity
    {
        [Column("category_name")]
        public string Name { get; set; }
        public virtual IList<ProductTitle> Titles { get; set; }
        public Category():base() { }
        public Category(int id, string name) : base(id)
        {
            this.Name = name;
        }
    }
}
