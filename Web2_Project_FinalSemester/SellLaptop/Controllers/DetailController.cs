using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellLaptop.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index(int? id)
        {
            using (var ent=new sellLaptopEntities())
            {
                san_pham sp = ent.san_pham.Include("o_dia_cung").Include("cart_do_hoa").Include("anh_sp").Include("hang_sx").Include("cpu").Where(a => a.masp == id).FirstOrDefault();
                return View(sp);
            }
            return View();
        }

        [ChildActionOnly]
        public ActionResult ShowCungHang(String hang)
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult ShowCungLoai(int loai)
        {
            return PartialView();
        }
    }
}