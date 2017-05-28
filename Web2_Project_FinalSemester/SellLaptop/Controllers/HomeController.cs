using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellLaptop.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {            
            return View();
        }

        public ActionResult Search()
        {
            return View();
        }

        public ActionResult Search(int page = 0)
        {
            return View();
        }

        [HttpGet]
        public ActionResult Search(searchProduct pro)
        {
            return View();
        }
    }
}