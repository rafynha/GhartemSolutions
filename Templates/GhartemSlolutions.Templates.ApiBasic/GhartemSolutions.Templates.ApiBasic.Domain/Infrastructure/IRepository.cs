using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GhartemSolutions.Templates.ApiBasic.Domain.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        int? Create(T entity);
        IEnumerable<T> GeatAll();
        void Delete(int id);
        T GetByID(int id);
        T GetByName(string name);
        int? Update(T entity);
    }
}
