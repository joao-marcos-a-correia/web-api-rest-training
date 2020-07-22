using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiECommerce.Domain.Repositories
{
    public interface IBaseRepository
    {
        void SaveChanges();
        void Reset();
    }
}
