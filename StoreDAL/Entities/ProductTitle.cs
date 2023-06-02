using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDAL.Entities
{
    // ToDo: add atribute here
    public class ProductTitle : BaseEntity
    {
        // ToDo: add atribute here
        public string Title { get; set; }
        // ToDo: add atribute here
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
