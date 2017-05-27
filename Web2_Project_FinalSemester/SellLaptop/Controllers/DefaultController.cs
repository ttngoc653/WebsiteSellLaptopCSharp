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
                List<cart_do_hoa> l = ent.cart_do_hoa.OrderBy(x =>x.thietke).ToList();
                String tam = "";
                for (int i = 0; i < l.Count; i++)
                {
                    if (tam == l[i].thietke)
                    {
                        l.RemoveAt(i);
                        i--;
                    }
                    else tam = l[i].thietke;
                }
                return PartialView(l);
            }
            return PartialView();
        }
        
        [ChildActionOnly]
        public ActionResult SearchDungLuongRam()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<san_pham> l = ent.san_pham.OrderBy(x => x.ramdl).ToList();
                int tam = 0;
                for (int i = 0; i < l.Count; i++)
                {
                    if (tam == l[i].ramdl)
                    {
                        l.RemoveAt(i);
                        i--;
                    }
                    else tam = l[i].ramdl;
                }
                return PartialView(l);
            }
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult SearchCPU()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<cpu> l = ent.cpus.OrderBy(x => x.congnghe).ToList();
                String tam = "";
                for (int i = 0; i < l.Count; i++)
                {
                    if (tam == l[i].congnghe)
                    {
                        l.RemoveAt(i);
                        i--;
                    }
                    else tam = l[i].congnghe;
                }
                return PartialView(l);
            }
            return PartialView();
        }
    }
}