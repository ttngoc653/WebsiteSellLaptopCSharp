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
        public ActionResult MenuRight()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult RightHangSX()
        {
            using (var ent=new sellLaptopEntities())
            {
                List<hang_sx> l = ent.hang_sx.ToList();
                return PartialView(l);
            }
        }

        [ChildActionOnly]
        public ActionResult RightCPU()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.cpus.Select(a => a.congnghe).Distinct().ToList();
                return PartialView(l);
            }
        }

        [ChildActionOnly]
        public ActionResult RightRAM()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<int> l = ent.san_pham.Select(a=>a.ramdl).Distinct().ToList();
                return PartialView(l);
            }
        }

        [ChildActionOnly]
        public ActionResult RightHDH()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.san_pham.Select(a=>a.hdh).Distinct().ToList();
                return PartialView(l);
            }
        }

        [ChildActionOnly]
        public ActionResult RightBoNho()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<o_dia_cung> ltemp = ent.o_dia_cung.ToList();
                ltemp = (from a in ltemp
                                      group a by a.masp into z
                                      select new o_dia_cung { san_pham = ent.san_pham.Where(y=>y.masp==z.Key).FirstOrDefault(), an = false, dungluong = z.Sum(s => s.dungluong), loaiodia = "", masp = z.Key }).ToList();
                List<int> l = ltemp.Select(a => a.dungluong).Distinct().OrderBy(a=>a).ToList();
                return PartialView(l);
            }
        }
    }
}