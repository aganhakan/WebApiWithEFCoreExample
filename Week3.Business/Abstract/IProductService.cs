using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Entities;

namespace Week3.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetByIdWithCategories(int id);
        List<Product> GetAll();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
