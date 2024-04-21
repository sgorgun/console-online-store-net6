using StoreDAL.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.X509Certificates;

namespace StoreBLL.Models
{
    public class ManufacturerModel : AbstractModel
    {
        public string ManufacturerName { get; set; }
        public ManufacturerModel(int id, string name) : base(id)
        {
            this.Id = id;
            this.ManufacturerName = name;
        }

        public override string ToString()
        {
            return $"Id:{Id} {ManufacturerName}";
        }
    }
}
