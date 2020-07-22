using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApiECommerce.Domain.Model.Customer;
using WebApiECommerce.Domain.Repositories;
using WebApiECommerce.Service.DTOs;
using WebApiECommerce.Service.Interfaces;

namespace WebApiECommerce.Service.Services
{
    public class CustomerService : ServiceBase, ICustomerService
    {
        protected override Type ConcreteType => typeof(ICustomerService);

        private ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        public List<Customer> ListAllCustomer()
        {
            List<Customer> response = new List<Customer>();

            try
            {
                response = _customerRepository.ListAllCustomers();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return response;
        }

        public void RegisterNewCustomer(string customerName, string customerType, byte? lenabled)
        {
            try
            {
                int customerCode = int.Parse(_customerRepository.GetMaxCustomerCode()) + 1;

                _customerRepository.Insert(new Customer {
                    CIdcustomer = customerCode.ToString(),
                    CCustomerName = customerName,
                    XCustomerType = customerType,
                    LEnabled = lenabled
                });
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
                
        }
    }
}
