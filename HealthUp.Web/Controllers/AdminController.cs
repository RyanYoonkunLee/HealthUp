using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUp.Data.Sql.Data.DataAccess;
using HealthUp.DataModel;
using HealthUp.ServiceLayer;
using HealthUp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace HealthUp.Web.wwwroot
{
    public class AdminController : Controller
    {
        ProductService service;
        Product productData;
        ProductDataAccess _data;
        public AdminController()
        {
            service = new ProductService();
            productData = new Product();
            _data = new ProductDataAccess();
        }

        public IActionResult Index()
        {
            var productList = _data.GetProducts();
            var productViewModelList = service.ConvertDataListToView(productList);
            return View(productViewModelList);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        public IActionResult SendProduct(ProductViewModel productView)
        {
            var convertedData = service.ConvertViewToData(productView);
            _data.Create(convertedData);

            return RedirectToAction("Index", "Admin");
        }

        public IActionResult ProductUpdate(Guid id)
        {
            var findProduct = _data.Find(id);
            var viewProduct = service.ConvertDataToView(findProduct);
            return View(viewProduct);
        }
        [HttpPost]
        [Route("Admin/ProductUpdate/{id?}")]
        public IActionResult ProductUpdate(ProductViewModel product)
        {
            var dataProduct = service.UpdateProductElement(product);
            dataProduct.name = product.name;
            _data.Update(dataProduct);
            return RedirectToAction("Index", "Admin");
        }

        public IActionResult Delete(Guid id)
        {
            _data.Delete(id);

            return RedirectToAction("Index", "Admin");
        }
    }
}