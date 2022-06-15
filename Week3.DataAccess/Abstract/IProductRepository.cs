using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Entities;

namespace Week3.DataAccess.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Product GetByIdWithCategories(int id);
        List<Product> GetWithSp();
    }
}
