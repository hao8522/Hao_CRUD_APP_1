using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hao_CRUD_APP_1.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Customers()
        {
            return View("Customers");
        }
    }
}