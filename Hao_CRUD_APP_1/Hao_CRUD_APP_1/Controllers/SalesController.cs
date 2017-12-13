using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hao_CRUD_APP_1.Models;
using Hao_CRUD_APP_1.Service;

namespace Hao_CRUD_APP_1.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        public ActionResult Sales()
        {
            var salesService = new SalesService();
            ViewBag.list = salesService.GetSaleList();
            return View("Sales");
        }
    }
}