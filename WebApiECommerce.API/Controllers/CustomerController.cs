using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiECommerce.Domain.Model.Customer;
using WebApiECommerce.Service.DTOs;
using WebApiECommerce.Service.Interfaces;

namespace WebApiECommerce.API.Controllers
{
    [Route("api/[controller]")]
    public class CustomerController : BaseController
    {
        private ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("ListCustomers")]
        public JsonResult ListCustomers()
        {
            List<Customer> customerBase = new List<Customer>();

            customerBase = _customerService.ListAllCustomer();

            return buildJsonResult(customerBase);
        }

        [HttpPost]
        [Route("NewCustomer")]
        public JsonResult CreateNewCustomer([FromBody] Customer customer)
        {
            ResponseBase response = new ResponseBase();

            string cCustomerName = customer.CCustomerName;
            string CustomerType = customer.XCustomerType;
            byte? lEnabled = customer.LEnabled;

            _customerService.RegisterNewCustomer(cCustomerName, CustomerType, lEnabled);

            return buildJsonResult(response);
        }
    }
}
