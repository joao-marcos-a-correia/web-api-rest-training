using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiECommerce.API.Controllers;
using WebApiECommerce.Domain.Repositories;
using WebApiECommerce.Infra.Repositories;
using WebApiECommerce.Service.Interfaces;
using WebApiECommerce.Service.Services;

namespace WebApiECommerce.API
{
    public class Register
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            //Interfaces
            services.AddTransient<ICustomerRepository, CustomerRepository>();


            //Services
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}
