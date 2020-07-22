using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WebApiECommerce.Domain.Model.Customer;

namespace WebApiECommerce.Infra.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<TbCustomer, Customer>().ReverseMap();
        }
    }
}
