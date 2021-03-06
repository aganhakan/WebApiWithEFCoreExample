using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Entities;

namespace Week3.DataAccess.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        void DeleteFromCategory(int productId, int categoryId);
    }
}
