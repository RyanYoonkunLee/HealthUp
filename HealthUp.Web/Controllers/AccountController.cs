using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthUp.DataModel;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HealthUp.Web.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        public IActionResult LogIn()
        {
            return View();
        }
        
        public IActionResult ValidationCheck(User login)
        {
            var input = login;

            return RedirectToAction("AdminIndex", "Admin");
        }
    }
}
