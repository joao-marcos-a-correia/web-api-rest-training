﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiECommerce.Domain.Repositories
{
    public interface IReadOnlyRepository<T>
    {
        IEnumerable<T> List(IDictionary<string, object> keys);
        T Get(IDictionary<string, object> keys);
    }
}
