using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUp.Data.Sql.Data.DataAccess;
using HealthUp.DataModel;
using HealthUp.ServiceLayer;
using HealthUp.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HealthUp.Web.wwwroot
{
    public class AdminController : Controller
    {
        ProductService service;
        ProductDataAccess _data;
        
        BestSellerDataAccess _best;
        BestSellerService bestSellerService;

        NewProductDataAccess _new;
        NewProductService newProductService;

        ArticleDataAccess _article;
        ArticleService articleService;

        public AdminController()
        {
            service = new ProductService();
            _data = new ProductDataAccess();

            _best = new BestSellerDataAccess();
            bestSellerService = new BestSellerService();

            _new = new NewProductDataAccess();
            newProductService = new NewProductService();

            _article = new ArticleDataAccess();
            articleService = new ArticleService();
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        #region Product
        public IActionResult ProductList()
        {
            var productList = _data.GetProducts();
            var productViewModelList = service.ConvertDataListToView(productList);
            return View(productViewModelList);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ProductCreate()
        {
            ViewBag.Functions = _data.GetFunctions();
            ViewBag.Categories = _data.GetCategories();
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(ProductViewModel productView)
        {
            if (ModelState.IsValid)
            {
                var convertedData = service.ConvertViewToData(productView);
                _data.Create(convertedData);

                return RedirectToAction("Index", "Admin");
            }
            else
            {
                ViewBag.Functions = _data.GetFunctions();
                ViewBag.Categories = _data.GetCategories();
                return View(productView);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ProductUpdate(Guid id)
        {
            var findProduct = _data.Find(id);
            var viewProduct = service.ConvertDataToView(findProduct, true);
            var functions = _data.GetFunctions();
            var categories = _data.GetCategories();

            ViewBag.Functions = service.SelectedFunctions(viewProduct.Function, functions);
            ViewBag.Categories = service.SelectedCategory(viewProduct.Category, categories);
            return View(viewProduct);
        }

        [HttpPost]
        [Route("Admin/ProductUpdate/{id?}")]
        public IActionResult ProductUpdate(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                var dataProduct = service.UpdateProductElement(product);
                dataProduct.Name = product.Name;
                _data.Update(dataProduct);
                return RedirectToAction("ProductList", "Admin");
            }
            else
            {
                var functions = _data.GetFunctions();
                var categories = _data.GetCategories();
                ViewBag.Functions = service.SelectedFunctions(product.Function, functions);
                ViewBag.Categories = service.SelectedCategory(product.Category, categories);
                return View(product);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Delete(Guid id)
        {
            _data.Delete(id);

            return RedirectToAction("ProductList", "Admin");
        }
        #endregion

        #region Article
        [Authorize(Roles = "Admin")]
        public IActionResult ArticleList()
        {
            var articles = _article.GetArticles();

            return View(articles);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ArticleCreate()
        {
            ViewBag.ProductList = _data.GetProducts();

            return View();
        }

        [HttpPost]
        public IActionResult ArticleCreate(ArticleViewModel article)
        {
            if (ModelState.IsValid)
            {
                article.Id = Guid.NewGuid();
                var dataArticle = articleService.ViewToData(article);
                _article.Create(dataArticle);

                return RedirectToAction("ArticleList", "Admin");
            }
            else
            {
                ViewBag.ProductList = _data.GetProducts();
                return View(article);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ArticleUpdate(Guid id)
        {
            var article = _article.FindById(id);
            var original = _data.GetProducts();
            ViewBag.ProductList = service.SplitSelectedProduct(article.RelateProduct, original);
            var articleView = articleService.DataToView(article);

            return View(articleView);
        }

        [HttpPost]
        public IActionResult ArticleUpdate(ArticleViewModel article)
        {
            if (ModelState.IsValid)
            {
                var dataArticle = articleService.ViewToData(article);
                _article.Update(dataArticle);

                return RedirectToAction("ArticleList", "Admin");
            }
            else
            {
                var original = _data.GetProducts();
                if(article.RelateProduct == null)
                {
                    ViewBag.ProductList = service.SplitSelectedProduct(null, original);
                }
                else
                {              
                    ViewBag.ProductList = service.SelectedProduct(article.RelateProduct.ToList(), original);
                }
                
                return View(article);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult ArticleDelete(Guid id)
        {
            _article.Delete(id);
            return RedirectToAction("ArticleList", "Admin");
        }

        #endregion

        #region NewProduct
        [Authorize(Roles = "Admin")]
        public IActionResult NewProductList()
        {
            var newProducts = _new.GetNewProduct();

            return View(newProducts);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult NewProductCreate()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult NewProductCreate(NewProduct newProduct)
        {
            if (ModelState.IsValid)
            {
                newProduct.Id = Guid.NewGuid();
                _new.Create(newProduct);

                return RedirectToAction("NewProductList", "Admin");
            }
            else
            {
                return View(newProduct);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult NewProductUpdate(Guid id)
        {
            var newProduct = _new.FindById(id);
            return View(newProduct);
        }
        [HttpPost]
        public IActionResult NewProductUpdate(NewProduct newProduct)
        {
            if (ModelState.IsValid)
            {
                _new.Update(newProduct);
                return RedirectToAction("NewProductList", "Admin");
            }
            else
            {
                return View(newProduct);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult NewProductDelete(Guid id)
        {
            _new.Delete(id);

            return RedirectToAction("NewProductList", "Admin");
        }
        #endregion

        [Authorize(Roles = "Admin")]
        public IActionResult BestSellerList()
        {
            var bestProducts = _best.GetBestSellers();
            return View(bestProducts);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult BestSellerCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BestSellerCreate(BestSeller bestSeller)
        {
            if (ModelState.IsValid)
            {
                bestSeller.Id = Guid.NewGuid();
                _best.Create(bestSeller);
                return RedirectToAction("BestSellerList", "Admin");
            }
            else
            {
                return View(bestSeller);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult BestSellerUpdate(Guid id)
        {
            var best = _best.FindById(id);
            return View(best);
        }
        [HttpPost]
        public IActionResult BestSellerUpdate(BestSeller bestSeller)
        {
            if(ModelState.IsValid)
            {
                _best.Update(bestSeller);
                return RedirectToAction("BestSellerList", "Admin");
            }
            else
            {
                return View(bestSeller);
            }
        }
        [Authorize(Roles = "Admin")]
        public IActionResult BestSellerDelete(Guid id)
        {
            _best.Delete(id);
            return RedirectToAction("BestSellerList", "Admin");
        }
    }
}