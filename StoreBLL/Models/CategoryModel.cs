using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreBLL.Models
{
    public class CategoryModel : AbstractModel
    {
        public CategoryModel(int id, string name):base(id) 
        {

        }
        public override string ToString()
        {
            throw new NotImplementedException();
        }
    }
}
