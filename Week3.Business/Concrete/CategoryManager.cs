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
    public class CategoryManager : ICategoryService
    {
        private readonly IUnitOfWork _unitofwork;
        public CategoryManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public void Create(Category entity)
        {
            _unitofwork.Categories.Create(entity);
            _unitofwork.Save();
        }

        public void Delete(Category entity)
        {
            _unitofwork.Categories.Delete(entity);
            _unitofwork.Save();
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            _unitofwork.Categories.DeleteFromCategory(productId, categoryId);
        }

        public List<Category> GetAll()
        {
            return _unitofwork.Categories.GetAll();
        }

        public Category GetById(int id)
        {
            return _unitofwork.Categories.GetById(id);
        }
        public void Update(Category entity)
        {
            _unitofwork.Categories.Update(entity);
            _unitofwork.Save();
        }
    }
}
