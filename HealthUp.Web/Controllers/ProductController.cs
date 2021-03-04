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
            else if(searchcolumn.Equals("Category") && sort.Equals("All"))
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
                    return RedirectToAction("FindName", "Product", new { id = productId.Id });
                }
            }

        }
        public IActionResult FindName(Guid id)
        {
            var product = _data.Find(id);
            return RedirectToAction("ProductDetail", new { name = product.Name, id = product.Id});
        }

        [Route("/ProductItem/{name}")]
        public IActionResult ProductDetail(string name, Guid id)
        {
            var product = _data.Find(id);
            var viewProduct = service.ConvertDataToView(product, false);
            ViewBag.Images = service.GetImages(viewProduct.ProductImages);
            return View(viewProduct);
        }

        public List<ProductViewModel> FindCategory(string name)
        {
            var products = new List<Product>();
            if (name.Equals("All"))
            {
                products = _data.GetProducts();
            }
            else
            {
                products = _data.GetCategoryByName(name);
            }

            var productview = service.ConvertDataListToView(products);
            return productview;
        }

        public List<ProductViewModel> FindFunction(string name)
        {
            var products = new List<Product>();

            products = _data.GetFunctionByName(name);
            

            var productview = service.ConvertDataListToView(products);
            return productview;
        }
    }
}