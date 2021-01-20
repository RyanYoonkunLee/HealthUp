using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUp.Data.Sql.Data.DataAccess;
using HealthUp.DataModel;
using HealthUp.ServiceLayer;
using HealthUp.ViewModel;
using Microsoft.AspNetCore.Mvc;
using static HealthUp.DataModel.Product;

namespace HealthUp.Web.Controllers
{
    public class ProductController : Controller
    {
        ProductService service;
        Product productData;
        ProductDataAccess _data;
        public ProductController()
        {
            service = new ProductService();
            productData = new Product();
            _data = new ProductDataAccess();
        }

        public IActionResult Index(string searchcolumn, string sort)
        {
            List<Product> productList = new List<Product>();

            if (searchcolumn == null && sort == null)
            {
                productList = _data.GetProducts();                           
            }
            else if (searchcolumn.Equals("Category") && sort != null)
            {
                productList = _data.GetCategoryByName(sort);
            }
            else if (searchcolumn.Equals("Function") && sort != null)
            {
                productList = _data.GetFunctionByName(sort);
            }
            else if (searchcolumn.Equals("Product") && sort != null)
            {
                productList = _data.GetProductByName(sort);
            }

            ViewBag.Categories = _data.GetCategories();
            ViewBag.Functions = _data.GetFunctions();

            if (productList.Count != 0)
            {
                var productViewModelList = service.ConvertDataListToView(productList);
                return View(productViewModelList);
            }
            else
            {
                return View();
            }
        }

        public IActionResult SearchProduct(string name)
        {
            if(name == null)
            {
                return RedirectToAction("Index", "Product");
            }
            else
            {
                var productId = _data.FindByName(name);

                if (productId == null)
                {
                    return RedirectToAction("Index", "Product", new { sort = name, searchcolumn = "Product" });
                }
                else
                {
                    return RedirectToAction("ProductDetail", "Product", new { id = productId.Id });
                }
            }

        }

        public IActionResult ProductDetail(Guid id)
        {
            var findProduct = _data.Find(id);
            var viewProduct = service.ConvertDataToView(findProduct, false);
            ViewBag.Images = service.GetImages(findProduct.ProductImages);
            return View(viewProduct);
        }

        public IActionResult Delete(Guid id)
        {
            _data.Delete(id);

            return RedirectToAction("Index", "Product");
        }
    }
}