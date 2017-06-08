using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellLaptop.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            if (Session["user"]==null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Index", "Index");
            }

            List<CartItem> l = null;
            if (Session["cart"]!=null)
            {
                l = Session["cart"] as List<CartItem>;
            }
            return View(l);
        }

        public ActionResult Pay()
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Index", "Index");
            }

            List<CartItem> l;
            if (Session["cart"] != null)
            {
                l = Session["cart"] as List<CartItem>;
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(int id, int sl = 1)
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return View();
            }

            List<CartItem> l;
            using (var ent = new sellLaptopEntities())
            {
                san_pham sp = ent.san_pham.Where(a => a.masp == id).FirstOrDefault();
                if (sp == null)
                {
                    WebMsgBox.ShowMessage(@"KHÔNG CÓ SẢN PHẨM NÀY!");
                }
                else
                {
                    if (Session["cart"] == null)
                    {
                        l = new List<CartItem>();
                        l.Add(new CartItem { sp = sp, Quatity = sl });
                        WebMsgBox.ShowMessage(@"ĐÃ THÊM THÀNH CÔNG \n HIỆN TẠI CÓ " + sl + @" MÁY " + sp.tenhangsx + " " + sp.tensp + @" TRONG GIỎ!");
                        Session["count_sp"] = sl;
                        Session["cart"] = l;
                    }
                    else
                    {
                        l = Session["cart"] as List<CartItem>;
                        Session["count_sp"] = ((int)Session["count_sp"]) + sl;
                        
                        int temp = l.Where(a => a.sp.masp == id).Count();
                        if (temp!=0)
                        {
                            CartItem ct = l.Where(a => a.sp.masp == id).FirstOrDefault();
                            l.Remove(ct);
                            l.Add(new CartItem { sp = sp, Quatity = sl + ct.Quatity });

                            WebMsgBox.ShowMessage(@"ĐÃ THÊM THÀNH CÔNG \n HIỆN TẠI CÓ " + (ct.Quatity + sl) + @" MÁY " + sp.tenhangsx + " " + sp.tensp + @" TRONG GIỎ!");

                            Session["cart"] = l;
                        }
                        else
                        {
                            l.Add(new CartItem { sp = sp, Quatity = sl });
                            WebMsgBox.ShowMessage(@"ĐÃ THÊM THÀNH CÔNG \n HIỆN TẠI CÓ " + sl + @" MÁY " + sp.tenhangsx + " " + sp.tensp + @" TRONG GIỎ!");
                        }
                    }
                }
            }
            return View();
        }

        public ActionResult Remove(int id)
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Index", "Index");
            }

            if (Session["cart"]==null)
            {
                WebMsgBox.ShowMessage(@"HÃY THÊM SẢN PHẨM VÀO GIỎ!");
                return RedirectToAction("Index", "Index");
            }

            List<CartItem> l = Session["cart"] as List<CartItem>;

            CartItem ct = l.Where(a => a.sp.masp == id).First();
            if (ct==null)
            {
                WebMsgBox.ShowMessage(@"KHÔNG TỒN TẠI SẢN PHẨM TRONG GIỎ HÀNG!");
                return RedirectToAction("Index", "Index");
            }

            Session["count_sp"] = ((int)Session["count_sp"]) - ct.Quatity;

            l.Remove(ct);
            Session["cart"] = l;

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Update(int id,int qua)
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Index", "Index");
            }

            if (Session["cart"] == null)
            {
                WebMsgBox.ShowMessage(@"HÃY THÊM SẢN PHẨM VÀO GIỎ!");
                return RedirectToAction("Index", "Index");
            }

            List<CartItem> l = Session["cart"] as List<CartItem>;

            CartItem ct = l.Where(a => a.sp.masp == id).First();
            if (ct == null)
            {
                WebMsgBox.ShowMessage(@"KHÔNG TỒN TẠI SẢN PHẨM TRONG GIỎ HÀNG!");
                return RedirectToAction("Index", "Index");
            }
            Session["count_sp"] = ((int)Session["count_sp"]) - ct.Quatity + qua;

            l.Remove(ct);
            ct.Quatity = qua;
            l.Add(ct);
            Session["cart"] = l;

            return RedirectToAction("Index");
        }
    }
}