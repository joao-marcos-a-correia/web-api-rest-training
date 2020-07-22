using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using WebApiECommerce.Domain.Model.Customer;
using WebApiECommerce.Domain.Repositories;
using WebApiECommerce.Infra.DBContext;

namespace WebApiECommerce.Infra.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(DbContextCommerce dbContextCommerce) : base(dbContextCommerce) { }

        public List<Customer> ListAllCustomers()
        {
            return
                _dbContext.TbCustomer
                .Where(x => x.LEnabled == 1)
                .Select(b => Mapper.Map<Customer>(b)).ToList();
        }

        public void Insert(Customer entity)
        {
            _dbContext.TbCustomer.Add(this.buildDbEntity(entity));
            _dbContext.SaveChanges();
        }

        public string GetMaxCustomerCode()
        {
           return _dbContext.TbCustomer
                .OrderByDescending(b => b.CIdcustomer)
                .Select(a => a.CIdcustomer)
                .FirstOrDefault();
        }

        private TbCustomer buildDbEntity(Customer entity)
        {
            TbCustomer value = Mapper.Map<TbCustomer>(entity);
            return value;
        }

        #region not implemented methods
        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> List(IDictionary<string, object> keys)
        {
            throw new NotImplementedException();
        }

        public Customer Get(IDictionary<string, object> keys)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
