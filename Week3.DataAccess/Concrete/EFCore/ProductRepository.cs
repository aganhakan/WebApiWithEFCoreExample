using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.DataAccess.Abstract;
using Week3.Entities;

namespace Week3.DataAccess.Concrete.EFCore
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(Week2Context context) : base(context)
        {

        }
        private Week2Context Week2Context
        {
            get { return context as Week2Context; }
        }
        public Product GetByIdWithCategories(int id)
        {
            return Week2Context.Products
                            .Where(i => i.Id == id)
                            .Include(i => i.Category)
                            .ThenInclude(i => i.CategoryName)
                            .FirstOrDefault();
        }
        public List<Product> GetWithSp()
        {
            var products = Week2Context.Products.FromSqlRaw("exec sp_GetWithSp").ToList();
            return products;
        }
    }
}
