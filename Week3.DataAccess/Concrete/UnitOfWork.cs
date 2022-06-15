using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.DataAccess.Abstract;
using Week3.DataAccess.Concrete.EFCore;

namespace Week3.DataAccess.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Week2Context _context;
        public UnitOfWork(Week2Context context)
        {
            _context = context;
        }

        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;
        private ProductFeatureRepository _productFeatureRepository;

        public IProductRepository Products =>
            _productRepository = _productRepository ?? new ProductRepository(_context);

        public ICategoryRepository Categories =>
            _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);

        public IProductFeatureRepository ProductFeatures =>
            _productFeatureRepository = _productFeatureRepository ?? new ProductFeatureRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
