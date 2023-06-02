using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreBLL.Models;

namespace StoreBLL.Interfaces
{
    public interface ICrud
    {
        IEnumerable<AbstractModel> GetAll();
        AbstractModel GetById(int id);
        void Add(AbstractModel model);
        void Update(AbstractModel model);
        void Delete(int modelId);
    }
}
