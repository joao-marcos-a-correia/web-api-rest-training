using System;
using System.Collections.Generic;
using System.Text;
using WebApiECommerce.Domain.Model.Customer;
using WebApiECommerce.Service.DTOs;

namespace WebApiECommerce.Service.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> ListAllCustomer();
        void RegisterNewCustomer(string customerName, string customerType, byte? lenabled);
    }
}
