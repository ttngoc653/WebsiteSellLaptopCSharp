using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellLaptop.Controllers
{
    public class MenuController : Controller
    {
        [ChildActionOnly]
        public ActionResult MenuTool()
        {
            if (Session["role"]!=null)
            {
                return PartialView();
            }
            return PartialView("Empty");
        }

        public ActionResult MenuAdmin()
        {
            if (Convert.ToBoolean(Session["role"]) == true)
            {
                return PartialView();
            }
            return PartialView("Empty");
        }

        public ActionResult MenuSystem()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult MenuRight()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult RightHangSX()
        {
            return PartialView(lHangSX());
        }

        [ChildActionOnly]
        public ActionResult SystemHangSX()
        {
            return PartialView(lHangSX());
        }

        private  List<String> lHangSX()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.hang_sx.Select(a=>a.tenhangsx).ToList();
                return l;
            }
        }

        [ChildActionOnly]
        public ActionResult RightCPU()
        {
            return PartialView(lCPU());
        }

        [ChildActionOnly]
        public ActionResult SystemCPU()
        {
            return PartialView(lCPU());
        }

        private List<String> lCPU()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.cpus.Select(a => a.congnghe).Distinct().ToList();
                return l;
            }
        }


        [ChildActionOnly]
        public ActionResult RightRAM()
        {
            return PartialView(lRAM());
        }

        [ChildActionOnly]
        public ActionResult SystemRAM()
        {
            return PartialView(lRAM());
        }

        private List<int> lRAM()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<int> l = ent.san_pham.Select(a => a.ramdl).Distinct().ToList();
                return l;
            }
        }

        [ChildActionOnly]
        public ActionResult RightHDH()
        {
            return PartialView(lHDH());
        }

        [ChildActionOnly]
        public ActionResult SystemHDH()
        {
            return PartialView(lHDH());
        }

        private List<String> lHDH()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.san_pham.Select(a => a.hdh).Distinct().ToList();
                return l;
            }
        }

        [ChildActionOnly]
        public ActionResult RightBoNho()
        {
            return PartialView(lBoNho());
        }

        [ChildActionOnly]
        public ActionResult SystemBoNho()
        {
            return PartialView(lBoNho());
        }

        private List<int> lBoNho()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<o_dia_cung> ltemp = ent.o_dia_cung.ToList();
                ltemp = (from a in ltemp
                         group a by a.masp into z
                         select new o_dia_cung { san_pham = ent.san_pham.Where(y => y.masp == z.Key).FirstOrDefault(), an = false, dungluong = z.Sum(s => s.dungluong), loaiodia = "", masp = z.Key }).ToList();
                List<int> l = ltemp.Select(a => a.dungluong).Distinct().OrderBy(a => a).ToList();
                return l;
            }
        }
    }
}