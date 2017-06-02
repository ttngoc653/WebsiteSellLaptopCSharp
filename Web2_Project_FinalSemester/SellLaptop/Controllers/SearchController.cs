using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellLaptop.Controllers
{
    public class SearchController : Controller
    {
        public ActionResult Search(searchProduct search)
        {
            using (var ent=new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Where(a => a.gia >= search.tu && a.gia <= search.den).ToList();
                if (search.key != null || search.key.Trim() != "") { l = l.Where(a => a.tenhangsx+" "+a.tensp==search.key).ToList(); }
                if (search.cpu != null || search.cpu != "") { l = l.Where(a => a.cpu.congnghe == search.cpu).ToList(); }
                if (search.ram != null || search.ram != 0) { l = l.Where(a => a.ramdl == search.ram).ToList(); }
                if (search.dohoa != null || search.dohoa != "") { l = l.Where(a => a.cart_do_hoa.thietke == search.dohoa).ToList(); }
                if (search.hang != null || search.hang != "") { l = l.Where(a => a.tenhangsx == search.hang).ToList(); }
                return View("SearchSP", l);
            }
        }
        /*public ActionResult SearchSP(string hangsx=null, string cpu = null, int ram = -1, string hdh = null, int bonho = -1)
        {
            using (var ent=new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();
                if (hangsx!=null)
                {
                    l = l.Where(a => a.tenhangsx==hangsx).ToList();
                }
                if (cpu!=null)
                {
                    l = l.Where(a => a.cpu.congnghe==cpu).ToList();
                }
                if (ram!=-1)
                {
                    l = l.Where(a => a.ramdl==ram).ToList();
                }
                if (hdh!=null)
                {
                    l = l.Where(a => a.hdh==hdh).ToList();
                }
                if (bonho!=-1)
                {
                    l = l.Where(a=>a.o_dia_cung==ent.o_dia_cung.GroupBy(b=>b.masp).Where(c=>c.Sum(d=>d.dungluong)==bonho)).ToList();
                }
                return View(l);
            }
        }*/
        
        public ActionResult SearchSPByHangSX(string hangsx=null)
        {
            using (var ent=new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();
                if (hangsx!=null)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM THUỘC HÃNG " + hangsx;
                    l = l.Where(a => a.tenhangsx==hangsx).ToList();
                }
                return View("SearchSP", l);
            }
        }

        public ActionResult SearchSPByCPU(string cpu = null)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();                
                if (cpu != null)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ CPU " + cpu;
                    l = l.Where(a => a.cpu.congnghe == cpu).ToList();
                }
                return View("SearchSP", l);
            }
        }
        public ActionResult SearchSPByRAM(int ram = -1)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();                
                if (ram != -1)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ RAM " + ram+" GB";
                    l = l.Where(a => a.ramdl == ram).ToList();
                }
                return View("SearchSP", l);
            }
        }

        public ActionResult SearchSPByHDH(string hdh = null)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();                
                if (hdh != null)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ THỂ CHẠY HỆ ĐIỀU HÀNH " + hdh;
                    l = l.Where(a => a.hdh == hdh).ToList();
                }
                return View("SearchSP",l);
            }
        }

        public ActionResult SearchSPByBoNho(int bonho = -1)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").Include("o_dia_cung").ToList();
                if (bonho != -1)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ BỘ NHỚ " + bonho+" GB";
                    l = ent.o_dia_cung.Include("san_pham").GroupBy(a => a.san_pham).Where(a => a.Sum(b => b.dungluong) == bonho).Select(a => a.Key).ToList();
                }
                return View("SearchSP", l);
            }
        }
    }
}