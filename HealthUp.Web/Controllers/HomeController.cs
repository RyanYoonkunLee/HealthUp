using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HealthUp.Web.Models;
using HealthUp.Data.Sql.Data.DataAccess;
using HealthUp.ServiceLayer;

namespace HealthUp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BestSellerDataAccess _bestseller;
        private BestSellerService _bestSellerService;
        private NewProductDataAccess _newproduct;
        private NewProductService _newProductService;
        private ProductRangeDataAccess _productRange;
        private ProductRangeService _productRangeService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _bestseller = new BestSellerDataAccess();
            _bestSellerService = new BestSellerService();
            _newproduct = new NewProductDataAccess();
            _newProductService = new NewProductService();
            _productRange = new ProductRangeDataAccess();
            _productRangeService = new ProductRangeService();
        }

        public IActionResult Index()
        {
            var bestSellerList = _bestseller.GetBestSellers();
            ViewBag.BestSellers = _bestSellerService.BestSellerDataToView(bestSellerList);
            var newProductList = _newproduct.GetNewProduct();
            ViewBag.NewProducts = _newProductService.DataToView(newProductList);
            var productRangeList = _productRange.GetProductRange();
            ViewBag.ProductRanges = _productRangeService.DataToView(productRangeList);

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
