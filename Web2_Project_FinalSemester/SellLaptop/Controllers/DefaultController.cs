using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;

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
        }
        
        [ChildActionOnly]
        public ActionResult SearchDungLuongRam()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<int> l = ent.san_pham.OrderBy(x => x.ramdl).Select(x => x.ramdl).Distinct().ToList();
                return PartialView(l);
            }
        }

        [ChildActionOnly]
        public ActionResult SearchCPU()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<String> l = ent.cpus.OrderBy(x => x.congnghe).Select(x=>x.congnghe).Distinct().ToList();
                
                return PartialView(l);
            }
        }

       [ChildActionOnly]
       public ActionResult Menu()
        {
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
                    u = ent.khach_hang.Where(x => x.tendn == username).First();
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
            String p = GetMD5(login.pass);
            khach_hang u;
            using (var ent=new sellLaptopEntities())
            {
                u = ent.khach_hang.Where(x => x.tendn == login.user && x.mk == p).FirstOrDefault();
            }
            if (u == null)
            {
                WebMsgBox.ShowMessage(@"ĐĂNG NHẬP THẤT BẠI.");
                return View();
            }
            else
            {
                if (Session["count_sp"] == null) Session["count_sp"] = 0;
                if (login.remember==true)
                {
                    Response.Cookies["user"]["name"] = u.tendn;
                    Response.Cookies["user"]["role"] = u.quyen.ToString();
                    Response.Cookies["user"].Expires = DateTime.Now.AddDays(3);
                }
                Session["user"] = u.tendn;
                Session["role"] = u.quyen;
                WebMsgBox.ShowMessage(@"ĐĂNG NHẬP THÀNH CÔNG.");
                return View();
            }            
        }

        public ActionResult LogOut()
        {

            if (Request.Cookies["user"] != null)
            {
                HttpCookie myCookie = new HttpCookie("user");
                myCookie.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookie);
            }

            String url = Session["url"].ToString();
            Session.RemoveAll();
            Session["url"] = url;
            if (Request.Cookies["user"] != null)
            {
                return RedirectToAction("LogOut");
            }
            return View("LogIn");
        }

        public ActionResult Register()
        {
            var model = new Register();
            return View(model);
        }
        
        [HttpPost]
        public ActionResult Register(Register obj,HttpPostedFileBase icon)
        {

            if (this.IsCaptchaValid("SAI CAPTCHA. HÃY NHẬP LẠI."))
            {
                using (var ent = new sellLaptopEntities())
                {
                    khach_hang kh = new khach_hang()
                    {
                        danh_gia = null,
                        don_hang = null,
                        email = obj.email,
                        gioitinh = obj.gioitinh,
                        hoten = obj.hoten,
                        mk = GetMD5(obj.mk),
                        ngsinh = obj.ngsinh,
                        quyen = false,
                        sdt = Convert.ToInt32(obj.sdt),
                        tendn = obj.tendn,
                    };
                    ent.khach_hang.Add(kh);
                    ent.SaveChanges();
                }
                HttpPostedFileBase hpf = Request.Files["icon"] as HttpPostedFileBase;
                if (hpf.ContentLength == 0)
                {
                    ViewBag.Message = "Invalid file type";
                    return View("SuccessRegister");
                }
                else
                {
                    string str = obj.tendn + ".jpg";
                    System.IO.File.Move(obj.icon.FileName, obj.tendn + ".jpg");
                    var path = Server.MapPath("~/Images/" + obj.tendn);
                    icon.SaveAs(path);
                }
                return View("SuccessRegister");
            }

            Session["error"] = "LỖI: CAPTCHA KHÔNG HỢP LỆ.";

            return View();
        }

        public ActionResult ChangeInfomationUser()
        {
            if (Session["user"]==null)
            {
                return RedirectToAction("Error", "Default");
            }

            using (var ent=new sellLaptopEntities())
            {
                String user = Session["user"] as String;
                khach_hang kh = ent.khach_hang.Where(a => a.tendn == user).First();
                Register r = kh;
                return View(r);
            }
        }

        [HttpPost]
        public ActionResult ChangeInfomationUser(Register model)
        {
            using (var ent = new sellLaptopEntities())
            {
                String user = Session["user"] as String;
                khach_hang kh = ent.khach_hang.Where(a => a.tendn == user).First();
                
                kh.email = model.email;
                kh.gioitinh = model.gioitinh;
                kh.hoten = model.hoten;
                kh.ngsinh = model.ngsinh;
                kh.sdt = Convert.ToInt32(model.sdt);

                ent.SaveChanges();
                
                return View(kh);
            }
        }

        public ActionResult ChangePassword()
        {
            if (Session["user"]==null)
            {
                return RedirectToAction("Error","Default");
            }
            return View();
        }

        [HttpPost]
        public ActionResult ChangePassword(ChangePassword model)
        {
            using (var ent=new sellLaptopEntities())
            {
                khach_hang kh = ent.khach_hang.Where(a => a.mk == GetMD5(model.passOld) && a.tendn == Convert.ToString(Session["user"])).First();
                if (kh==null)
                {
                    Session["error"] = "KHÔNG THỂ ĐỔI MẬT KHẨU\nVÌMẬT KHẨU CŨ KHÔNG CHÍNH XÁC";
                }
                else
                {
                    kh.mk = GetMD5(model.passNew);
                    ent.SaveChanges();
                    Session["error"] = "ĐỔI MẬT KHẨU THÀNH CÔNG";
                }
            }

            return View();
        }

        /*public ActionResult Register1()
        {
            var model = new Register();
            return View(model);
        }

        [HttpPost]
        public ActionResult Register1(Register obj, HttpPostedFileBase icon)
        {

            if (this.IsCaptchaValid("SAI CAPTCHA. HÃY NHẬP LẠI."))
            {
                if (Request.Files.Count == 0)
                {
                    ViewBag.Message = "Invalid file type";
                }
                else
                {
                    using (var ent = new sellLaptopEntities())
                    {
                        khach_hang kh = new khach_hang()
                        {
                            danh_gia = null,
                            don_hang = null,
                            email = obj.email,
                            gioitinh = obj.gioitinh,
                            hoten = obj.hoten,
                            mk = GetMD5(obj.mk),
                            ngsinh = obj.ngsinh,
                            quyen = false,
                            sdt = Convert.ToInt32(obj.sdt),
                            tendn = obj.tendn,
                        };
                        ent.khach_hang.Add(kh);
                        ent.SaveChanges();
                    }
                    var fileName = Path.GetFileName(icon.FileName);
                    //File.Copy(obj.tendn, ob)
                    var path = Path.Combine(Server.MapPath("~/Images/"), fileName);
                    icon.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
                }
                return View();
            }

            Session["captcha"] = "LỖI: CAPTCHA KHÔNG HỢP LỆ.";

            return View();
        }*/

        public JsonResult ValidationUser(String tendn)
        {
            var ent = new sellLaptopEntities();
            String ten = tendn;
            if (ent.khach_hang.Where(a=>a.tendn==tendn).ToList().Count!=0)
            {
                return Json("TÀI KHOẢN BỊ TRÙNG. HÃY NHẬP LẠI TÊN TÀI KHOẢN.", JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        /*public JsonResult ValidationDieuKhoan(String chapnhandieukhoan)
        {
            var ent = new sellLaptopEntities();
            if (chapnhandieukhoan=="false")
            {
                return Json("HÃY NHẤP VÀO Ô CHẤP NHẬN ĐIỀU KHOẢN.", JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }*/

        public JsonResult ValidationNgSinh(String ngsinh)
        {
            var ent = new sellLaptopEntities();DateTime dt;
            if (String.IsNullOrEmpty(ngsinh)||DateTime.TryParse(ngsinh,out dt)==false)
            {
                return Json("NGÀY SINH ĐỊNH DẠNG CHƯA ĐÚNG.", JsonRequestBehavior.AllowGet);
            }
            if (dt.Year>=DateTime.Now.AddYears(-12).Year)
            {
                return Json("KHÁCH HÀNG PHẢI TRÊN 12 TUỐI MỚI ĐƯỢC THAM GIA.", JsonRequestBehavior.AllowGet);
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        // source: http://www.hanhtranglaptrinh.com/2012/06/ma-hoa-md5-trong-c-aspnet.html
        public string GetMD5(string str)
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

        public ActionResult Error()
        {
            return View();
        }
    }
}