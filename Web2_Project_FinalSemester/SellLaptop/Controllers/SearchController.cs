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
                List<san_pham> l = ent.san_pham.Include("cpu").Where(a => a.gia >= search.tu*100000 && a.gia <= search.den*100000).ToList();
                if (search.key != null) { l = l.Where(a => String.Concat(a.tenhangsx+" "+a.tensp).ToUpper().Contains(search.key.ToUpper())).ToList(); }
                if (search.hang != null) { l = l.Where(a => a.tenhangsx == search.hang).ToList(); }
                if (search.cpu != null) { l = l.Where(a => a.cpu.congnghe == search.cpu).ToList(); }
                if (search.ram != 0) { l = l.Where(a => a.ramdl == search.ram).ToList(); }
                if (search.dohoa != null) { l = l.Where(a => a.cart_do_hoa.thietke == search.dohoa).ToList(); }

                Session["sp"] = l;
                Session["npage"] = l.Count / 8 + ((l.Count % 8 > 0) ? 1 : 0);
                Session["page"] = 1;
                ViewBag.Title = "KẾT QUẢ TÌM KIẾM";
                return View("SearchSP", l.Take(8).ToList());
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
        
        public ActionResult SearchSPByHangSX(String id=null)
        {
            using (var ent=new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();
                if (id!=null)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM THUỘC HÃNG " + id;
                    l = l.Where(a => a.tenhangsx==id).ToList();
                }
                Session["sp"] = l;
                Session["npage"] = l.Count / 8 + ((l.Count % 8 > 0) ? 1 : 0);
                Session["page"] = 1;
                return View("SearchSP", l.Take(8).ToList());
            }
        }

        public ActionResult SearchSPByCPU(string id = null)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();                
                if (id != null)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ CPU " + id;
                    l = l.Where(a => a.cpu.congnghe == id).ToList();
                }
                Session["sp"] = l;
                Session["npage"] = l.Count / 8 + ((l.Count % 8 > 0) ? 1 : 0);
                Session["page"] = 1;
                return View("SearchSP", l.Take(8).ToList());
            }
        }
        public ActionResult SearchSPByRAM(int id = -1)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();                
                if (id != -1)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ RAM " + id+" GB";
                    l = l.Where(a => a.ramdl == id).ToList();
                }
                Session["sp"] = l;
                Session["npage"] = l.Count / 8 + ((l.Count % 8 > 0) ? 1 : 0);
                Session["page"] = 1;
                return View("SearchSP", l.Take(8).ToList());
            }
        }

        public ActionResult SearchSPByHDH(string id = null)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").ToList();                
                if (id != null)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ THỂ CHẠY HỆ ĐIỀU HÀNH " + id;
                    l = l.Where(a => a.hdh == id).ToList();
                }
                Session["sp"] = l;
                Session["npage"] = l.Count / 8 + ((l.Count % 8 > 0) ? 1 : 0);
                Session["page"] = 1;
                return View("SearchSP", l.Take(8).ToList());
            }
        }

        public ActionResult SearchSPByBoNho(int id = -1)
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.Include("cpu").Include("o_dia_cung").ToList();
                if (id != -1)
                {
                    ViewBag.Title = "KẾT QUẢ TÌM KIẾM SẢN PHẨM CÓ BỘ NHỚ " + id+" GB";
                    l = ent.o_dia_cung.Include("san_pham").GroupBy(a => a.san_pham).Where(a => a.Sum(b => b.dungluong) == id).Select(a => a.Key).ToList();
                }
                Session["sp"] = l;
                Session["npage"] = l.Count / 8 + ((l.Count % 8>0) ? 1 : 0);
                Session["page"] = 1;
                return View("SearchSP", l.Take(8).ToList());
            }
        }

        public ActionResult SearchSPByPage(int page=0)
        {
            List<san_pham> l = Session["sp"] as List<san_pham>;
            if (page>0)
            {
                ViewBag.Title = "KẾT QUẢ TÌM KIẾM";
                l = l.Skip((page - 1) * 8).ToList();
            }
            Session["page"] = page;
            return View("SearchSP", l.Take(8).ToList());
        }
    }
}