using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiECommerce.Domain.Model.Customer
{
    public class Customer
    {
        public string CIdcustomer { get; set; }
        public string CCustomerName { get; set; }
        public string XCustomerType { get; set; }
        public byte? LEnabled { get; set; }
    }
}
