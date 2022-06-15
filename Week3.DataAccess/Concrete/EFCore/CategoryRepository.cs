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
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(Week2Context context) : base(context)
        {

        }
        private Week2Context Week2Context
        {
            get { return context as Week2Context; }
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            var cmd = "delete from productcategory where ProductId=@p0 and CategoryId=@p1";
            Week2Context.Database.ExecuteSqlRaw(cmd, productId, categoryId);
        }
    }
}
