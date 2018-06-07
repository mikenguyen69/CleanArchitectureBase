using CleanArchitectureBase.Core.SharedKernel;
using System.Collections.Generic;

namespace CleanArchitectureBase.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        List<T> List();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
