using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiECommerce.Domain.Repositories
{
    public interface IRepository<T> : IReadOnlyRepository<T>, IBaseRepository
    {
        void Update(T entity);
        void Insert(T entity);
    }
}
