using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellLaptop.Controllers
{
    public class DefaultController : Controller
    {
        [ChildActionOnly]
        public ActionResult Search() { return PartialView(); }
             
        [ChildActionOnly]
        public ActionResult SearchListHangSX()
        {
            using (var ent=new sellLaptopEntities())
            {
                List<hang_sx> l = ent.hang_sx.ToList();
                return PartialView(l);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult SearchGiaCa() { return PartialView(); }

        [ChildActionOnly]
        public ActionResult SearchDoHoa()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.cart_do_hoa.OrderBy(x =>x.thietke).Select(x=>x.thietke).Distinct().ToList();
                
                return PartialView(l);
            }
            return PartialView();
        }
        
        [ChildActionOnly]
        public ActionResult SearchDungLuongRam()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<int> l = ent.san_pham.OrderBy(x => x.ramdl).Select(x => x.ramdl).Distinct().ToList();
                return PartialView(l);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult SearchCPU()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.cpus.OrderBy(x => x.congnghe).Select(x=>x.congnghe).Distinct().ToList();
                
                return PartialView(l);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Log()
        {
            Session["user"] = "abc";
            if (Session["user"]==null)
            {
                return PartialView();
            }
            else
            {
                return PartialView("LogIned");
            }
        }
    }
}