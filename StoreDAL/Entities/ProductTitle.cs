using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    [Table("product_titles")]
    public class ProductTitle : BaseEntity
    {
        [Column("product_title")]
        public string Title { get; set; }

        [ForeignKey("Category")]
        [Column("category_id")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public virtual IList<Product> Products { get; set; }

        public ProductTitle() : base() { }
        public ProductTitle(int id, string title, int categoryId) : base(id)
        {
            this.Title = title;
            this.CategoryId = categoryId;
        }
    }
}
