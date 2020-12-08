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

        public IActionResult Index()
        {
            var productList = _data.GetProducts();
            var productViewModelList = service.ConvertDataListToView(productList);
            return View(productViewModelList);
        }

        public IActionResult ProductDetail(Guid id)
        {
            var findProduct = _data.Find(id);
            var viewProduct = service.ConvertDataToView(findProduct);
            return View(viewProduct);
        }

        public IActionResult Delete(Guid id)
        {
            _data.Delete(id);

            return RedirectToAction("Index", "Product");
        }
    }
}