using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Business.Abstract;
using Week3.DataAccess.Abstract;

namespace Week3.Business.Concrete
{
    public class ProductFeatureManager : IProductFeatureService
    {
        private readonly IUnitOfWork _unitofwork;
        public ProductFeatureManager(IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
    }
}
