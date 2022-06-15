using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3.DataAccess.Abstract
{
    public interface IGenericRepository<T>
    {
        T GetById(int id);

        List<T> GetAll();

        void Create(T entity);

        void Update(T entity);
        void Delete(T entity);
    }
}
