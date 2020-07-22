using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiECommerce.Service.Services
{
    public abstract class ServiceBase
    {
        protected abstract Type ConcreteType { get; }
    }
}
