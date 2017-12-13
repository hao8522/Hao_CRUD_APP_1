using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hao_CRUD_APP_1.Models;
using Hao_CRUD_APP_1.Service;
namespace Hao_CRUD_APP_1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ProductList()
        {

            List<Product> productList = new ProductService().GetAllProduct();

            ViewBag.list = productList;
            return View("Products");
        }

        public ActionResult LoadingModifyProducts(int productId)
        {
            Product product = new ProductService().GetProductById(productId);



            return View("ModifyProduct", product);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ModifyProduct(Product product)
        {
            int result = new ProductService().ModifyProduct(product);

            if (result > 0)
            {
                return Content("<script>alert('Modify Product successfully');location.href='" + Url.Content(" ProductList") + "'</script>");
            }
            else
            {
                return Content("<script>alert('Can you modify again?');location.href='" + Url.Content("ProductList") + "'</script>");
            }
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddProduct(Product product)
        {
           

            if (ModelState.IsValid)
            {

                int result = new ProductService().AddProduct(product);
                if (result > 0)
                {
                    return Content("<script>alert('Add Product Successfully');location.href='" + Url.Action("ProductList") + "'</script>");
                }
                else
                {
                    return Content("<script>alert('Can you add again?');location.href='" + Url.Action("ProductList") + "'</script>");
                }

            }
            else
            {
                return View("AddProduct");
            }
           

        }

        public ActionResult DeleteProducts(int productId)
        {

            int result = new ProductService().DeleteProduct(productId);

            if (result > 0)
            {
                return Content("<script>alert('Delete Product succssfully');location.href='" + Url.Action("ProductList") + "'</script>");
            }
            else
            {
                return Content("<script>alert('Can you try again?');location.href='" + Url.Action("ProductList") + "'</script>");
            }

        }
    }
}