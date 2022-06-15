using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Business.Abstract;
using Week3.DataAccess.Abstract;
using Week3.Entities;

namespace Week3.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitofwork;
        public ProductManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }

        public void Create(Product entity)
        {
            _unitofwork.Products.Create(entity);
            _unitofwork.Save();

        }

        public void Delete(Product entity)
        {
            // iş kuralları
            _unitofwork.Products.Delete(entity);
            _unitofwork.Save();
        }

        public List<Product> GetAll()
        {
            return _unitofwork.Products.GetAll();
        }

        public Product GetById(int id)
        {
            return _unitofwork.Products.GetById(id);
        }

        public Product GetByIdWithCategories(int id)
        {
            return _unitofwork.Products.GetByIdWithCategories(id);
        }
        public void Update(Product entity)
        {
            _unitofwork.Products.Update(entity);
            _unitofwork.Save();
        }
    }
}
