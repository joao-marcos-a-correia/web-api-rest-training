using System;
using System.Collections.Generic;
using System.Text;
using WebApiECommerce.Domain.Model.Customer;

namespace WebApiECommerce.Domain.Repositories
{
    public interface ICustomerRepository: IRepository<Customer>
    {
        List<Customer> ListAllCustomers();
        string GetMaxCustomerCode();
    }
}
