using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiECommerce.API.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {

        }

        public JsonResult buildJsonResult(object data)
        {
            return new JsonResult(
                data
                );
        }
    }
}
