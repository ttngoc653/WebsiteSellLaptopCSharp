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
            if (id==null)
            {
                return RedirectToAction("Error","Default");
            }
            using (var ent=new sellLaptopEntities())
            {                
                san_pham sp = ent.san_pham.Include("o_dia_cung").Include("cart_do_hoa").Include("anh_sp").Include("hang_sx").Include("cpu").Where(a => a.masp == id).FirstOrDefault();
                sp.luotview++;
                ent.SaveChanges();
                return View(sp);
            }
            return View();
        }

        [ChildActionOnly]
        public ActionResult ShowComment(int id)
        {
            using (var ent=new sellLaptopEntities())
            {
                return PartialView(ent.danh_gia.Include("khach_hang").Where(a=>a.masp== id).ToList());
            }
        }

        [ChildActionOnly]
        public ActionResult CreateComment(int id)
        {
            return PartialView(id);
        }

        [HttpPost]
        public ActionResult CreateComment(danh_gia model)
        {
            using (var ent =new sellLaptopEntities())
            {
                model.san_pham = ent.san_pham.Where(a => a.masp == model.masp).First();
                model.khach_hang = ent.khach_hang.Where(a => a.tendn == model.khachhang).First();
                ent.danh_gia.Add(model);
                ent.SaveChanges();
            }
            return RedirectToAction("Index", "Detail", new { id = model.masp });
        }

        [ChildActionOnly]
        public ActionResult ShowCungHang(String hang)
        {
            using (var ent=new sellLaptopEntities())
            {                
                return PartialView("Show5SPCung", ent.san_pham.Include("cpu").Where(a => a.tenhangsx == hang).Take(5).ToList());
            }
        }

        [ChildActionOnly]
        public ActionResult ShowCungLoai(int loai)
        {
            using (var ent = new sellLaptopEntities())
            {
                loai = (((int)loai / 1000000 - 5) * 1000000);
                return PartialView("Show5SPCung", ent.san_pham.Include("cpu").Where(a => a.gia>loai).Take(5).ToList());
            }
        }
    }
}