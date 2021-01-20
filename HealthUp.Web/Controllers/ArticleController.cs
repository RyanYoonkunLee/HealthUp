using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUp.Data.Sql.Data.DataAccess;
using HealthUp.ServiceLayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthUp.Web.Controllers
{
    public class ArticleController : Controller
    {
        // GET: /<controller>/
        ArticleDataAccess _article;
        ArticleService articleService;

        ProductDataAccess _product;
        ProductService productService;
        public ArticleController()
        {
            _article = new ArticleDataAccess();
            articleService = new ArticleService();
            _product = new ProductDataAccess();
            productService = new ProductService();
        }
        public IActionResult Index()
        {
            var list = _article.GetArticles();
            var viewList = articleService.DataToListView(list);

            return View(viewList);
        }

        public IActionResult ArticleDetail(Guid id)
        {
            var article = _article.FindById(id);
            var viewModel = articleService.DataToDetailView(article);
            ViewBag.RelatedProducts = productService.ConvertDataListToView(_product.GetRelatedProduct(article.RelateProduct));

            return View(viewModel);
        }
    }
}
