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
        
        [ChildActionOnly]
        public ActionResult ShowTop10Buy()
        {
            /*
            select san_pham.masp,san_pham.tensp,san_pham.hangsx,san_pham.gia,san_pham.icon,sum(chi_tiet_don_hang.soluongsp) sl 
            FROM san_pham,chi_tiet_don_hang 
            WHERE san_pham.masp = chi_tiet_don_hang.masp 
            GROUP BY san_pham.masp 
            order by sum(soluongsp)desc 
            LIMIT 10*/
            using (var ent = new sellLaptopEntities())
            {
                IList<chi_tiet_don_hang> lFull = ent.chi_tiet_don_hang.Include("san_pham").ToList();
                List<chi_tiet_don_hang> l = (from a in lFull
                            group a by a.masp into z
                            select new chi_tiet_don_hang {san_pham=ent.san_pham.Include("cpu").Where(a=>a.masp==z.Key).FirstOrDefault(),don_hang=null,madh=0, masp = z.Key, soluongsp = z.Sum(a => a.soluongsp) }).OrderByDescending(a=>a.soluongsp).ToList();
                l = l.Take(10).ToList();
                return PartialView(l);
            }
        }

        [ChildActionOnly]
        public ActionResult ShowTop10New()
        {
            using (var ent=new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").OrderByDescending(a => a.masp).Take(10).ToList();
                return PartialView(l);
            }
        }

        [ChildActionOnly]
        public ActionResult ShowTop10View()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").OrderByDescending(a => a.luotview).Take(10).ToList();
                return PartialView(l);
            }
        }
    }
}