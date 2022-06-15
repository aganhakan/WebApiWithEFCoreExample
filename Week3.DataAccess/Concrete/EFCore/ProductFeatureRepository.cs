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
    public class ProductFeatureRepository : GenericRepository<ProductFeature>, IProductFeatureRepository
    {
        public ProductFeatureRepository(Week2Context context) : base(context)
        {

        }
    }
}
