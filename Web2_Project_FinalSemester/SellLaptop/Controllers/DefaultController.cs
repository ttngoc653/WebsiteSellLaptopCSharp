using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
            if (Request.Cookies["user"]!=null)
            {
                Session["user"] = Request.Cookies["user"]["name"];
                Session["role"] = Request.Cookies["user"]["role"];
            }
            if (Session["user"]==null)
            {
                return PartialView();
            }
            else
            {
                khach_hang u;
                using (var ent = new sellLaptopEntities())
                {
                    String username = Session["user"].ToString();
                    u = ent.khach_hang.Where(x => x.tendn == username).FirstOrDefault();
                }
                return PartialView("LogIned",u);
            }
        }

        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LogIn login)
        {
            khach_hang u;
            using (var ent=new sellLaptopEntities())
            {
                u = ent.khach_hang.Where(x => x.tendn == login.user).FirstOrDefault();
            }
            if (u == null)
            {
                WebMsgBox.ShowMessage(@"ĐĂNG NHẬP THẤT BẠI.");
                return View();
            }
            else
            {
                if (login.remenber==true)
                {
                    Response.Cookies["user"]["name"] = u.tendn;
                    Response.Cookies["user"]["role"] = u.quyen.ToString();
                    Response.Cookies["user"].Expires = DateTime.Now.AddDays(3);
                }
                Session["user"] = u.tendn;
                WebMsgBox.ShowMessage(@"ĐĂNG NHẬP THÀNH CÔNG.");
                return View();
            }            
        }

        public ActionResult LogOut()
        {
            if (Request.Cookies["user"] != null)
            {
                Response.Cookies["user"].Expires = DateTime.Now.AddDays(-1);
            }
            String url = Session["url"].ToString();
            Session.RemoveAll();
            Session["url"] = url;
            return View("LogIn");
        }

        // source: http://www.hanhtranglaptrinh.com/2012/06/ma-hoa-md5-trong-c-aspnet.html
        public static string GetMD5(string str)
        {

            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            StringBuilder sbHash = new StringBuilder();

            foreach (byte b in bHash)
            {

                sbHash.Append(String.Format("{0:x2}", b));

            }

            return sbHash.ToString();

        }
    }
}