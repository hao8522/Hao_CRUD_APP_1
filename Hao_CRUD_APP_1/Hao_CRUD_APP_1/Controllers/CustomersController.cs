using Hao_CRUD_APP_1.Models;
using Hao_CRUD_APP_1.Service;
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
        public ActionResult CustomersList()
        {

            List<Customer> customerList = new CustomersService().GetAllCustomer();

            ViewBag.list = customerList;
            return View("Customers");
        }


        /// <summary>
        /// delete customers
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public ActionResult DeleteCustomer(int customerId)
        {
            int result = new CustomersService().DeleteCustomer(customerId);

            if (result > 0)
            {
                return Content("<script>alert('Delete Customer succssfully');location.href='" + Url.Action("CustomersList") + "'</script>");
            }
            else
            {
                return Content("<script>alert('Can you try again?');location.href='" + Url.Action("CustomersList") + "'</script>");
            }
        }

        /// <summary>
        /// loading modify customer
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public ActionResult LoadingModifyCustomer(int customerId)
        {
            Customer customer = new CustomersService().GetCustomerById(customerId);

            return View("ModifyCustomer", customer);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ModifyCustomer(Customer customer)
        {
            int result = new CustomersService().ModifyCustomer(customer);

            if (result > 0)
            {
                return Content("<script>alert('Modify Customer successfully');location.href='" + Url.Content("CustomersList") + "'</script>");
            }
            else
            {
                return Content("<script>alert('Can you modify again?');location.href='" + Url.Content("CustomersList") + "'</script>");
            }
        }

        [HttpPost]
        
        public ActionResult AddCustomer(Customer customer)
        {


            if (ModelState.IsValid)
            {
                int result = new CustomersService().AddCustomer(customer);
               
             
               
                  

                    if (result > 0)
                    {
                        return Content("<script>alert('Add Customer Successfully');location.href='" + Url.Action("CustomersList") + "'</script>");
                    }
                    else
                    {
                        return Content("<script>alert('Can you add again?');location.href='" + Url.Action("CustomersList") + "'</script>");
                    }

               
                

            }
            else
            {

                return View("AddCustomer");
            }

            
        }
    }
}