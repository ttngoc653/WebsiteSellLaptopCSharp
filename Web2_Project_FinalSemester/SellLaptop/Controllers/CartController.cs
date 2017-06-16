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
                return RedirectToAction("Error", "Default");
            }

            List<CartItem> l = new List<CartItem>();
            if (Session["cart"]!=null)
            {
                l = Session["cart"] as List<CartItem>;
            }
            return View(l);
        }

        [HttpPost]
        public ActionResult Pay(String address,long total)
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Error", "Default");
            }

            List<CartItem> l;
            if (Session["cart"] != null)
            {
                l = Session["cart"] as List<CartItem>;
                DateTime dtorder = DateTime.Now;
                using (var ent=new sellLaptopEntities())
                {
                    don_hang dh = new don_hang()
                    {
                        dagiao = false,
                        diachinhan = address,
                        khachhang = (String)Session["user"],
                        ngaygiolap = dtorder,
                        tongtien = total,
                        khach_hang = ent.khach_hang.Where(a => a.tendn == (String)Session["user"]).FirstOrDefault(),
                        chi_tiet_don_hang = null
                    };
                    ent.don_hang.Add(dh);
                    ent.SaveChanges();

                    int id = ent.don_hang.Where(a => a.khachhang == (String)Session["user"] && a.ngaygiolap == dtorder && a.tongtien == total).Select(a => a.madh).FirstOrDefault();

                    foreach (var item in l)
                    {
                        chi_tiet_don_hang ctdh = new chi_tiet_don_hang()
                        {
                            don_hang = ent.don_hang.Where(a => a.madh == id).FirstOrDefault(),
                            madh = id,
                            masp = item.sp.masp,
                            san_pham = ent.san_pham.Where(a => a.masp == item.sp.masp).FirstOrDefault(),
                            soluongsp = item.Quatity
                        };

                        san_pham sp = ent.san_pham.Where(a => a.masp == item.sp.masp).FirstOrDefault();
                        sp.slcon -= item.Quatity;

                        ent.chi_tiet_don_hang.Add(ctdh);

                        ent.SaveChanges();
                    }

                    Session["cart"] = null;
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Add(int id, int sl = 1)
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Error", "Default");
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
                    if (sp.slcon < sl)
                    {
                        WebMsgBox.ShowMessage("KHÔNG THỂ THÊM VÌ SỐ LƯỢNG MÀ SHOP HIỆN CÓ KHÔNG ĐỦ");
                    }
                    else if (Session["cart"] == null)
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

                            if (sp.slcon < sl+ct.Quatity)
                            {
                                WebMsgBox.ShowMessage("KHÔNG THỂ THÊM VÌ SỐ LƯỢNG MÀ SHOP HIỆN CÓ KHÔNG ĐỦ");
                            }
                            else
                            {
                                l.Remove(ct);
                                l.Add(new CartItem { sp = sp, Quatity = sl + ct.Quatity });

                                WebMsgBox.ShowMessage(@"ĐÃ THÊM THÀNH CÔNG \n HIỆN TẠI CÓ " + (ct.Quatity + sl) + @" MÁY " + sp.tenhangsx + " " + sp.tensp + @" TRONG GIỎ!");

                                Session["cart"] = l;
                            }
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

        public ActionResult Delete(int id)
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Error", "Default");
            }

            if (Session["cart"]==null)
            {
                WebMsgBox.ShowMessage(@"HÃY THÊM SẢN PHẨM VÀO GIỎ!");
                return RedirectToAction("Index", "Home");
            }

            List<CartItem> l = Session["cart"] as List<CartItem>;

            CartItem ct = l.Where(a => a.sp.masp == id).First();
            if (ct==null)
            {
                WebMsgBox.ShowMessage(@"KHÔNG TỒN TẠI SẢN PHẨM TRONG GIỎ HÀNG!");
                return RedirectToAction("Index");
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
                return RedirectToAction("Error", "Default");
            }

            if (Session["cart"] == null)
            {
                WebMsgBox.ShowMessage(@"HÃY THÊM SẢN PHẨM VÀO GIỎ!");
                return RedirectToAction("Index", "Home");
            }

            List<CartItem> l = Session["cart"] as List<CartItem>;

            CartItem ct = l.Where(a => a.sp.masp == id).First();
            if (ct == null)
            {
                WebMsgBox.ShowMessage(@"KHÔNG TỒN TẠI SẢN PHẨM TRONG GIỎ HÀNG!");
                return RedirectToAction("Index", "Home");
            }

            Session["count_sp"] = ((int)Session["count_sp"]) - ct.Quatity + qua;
            if (ct.sp.slcon < qua)
            {
                WebMsgBox.ShowMessage("KHÔNG THỂ THÊM VÌ SỐ LƯỢNG MÀ SHOP HIỆN CÓ KHÔNG ĐỦ");
            }
            else
            {
                l.Remove(ct);
                ct.Quatity = qua;
                l.Add(ct);
                Session["cart"] = l;
            }
            return RedirectToAction("Index");
        }

        public ActionResult HistoryBuy()
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Error", "Default");
            }

            using (var ent = new sellLaptopEntities())
            {
                List<don_hang> l = new List<don_hang>();
                String user = Session["user"] as String;
                l = ent.don_hang.Include("chi_tiet_don_hang").Where(a => a.khachhang == user).OrderByDescending(a=>a.ngaygiolap).ToList();
                return View(l);
            }
        }

        public ActionResult Detail(int id)
        {
            if (Session["user"] == null)
            {
                WebMsgBox.ShowMessage(@"YÊU CẦU ĐĂNG NHẬP!");
                return RedirectToAction("Error", "Default");
            }

            using (var ent=new sellLaptopEntities())
            {
                don_hang dh = ent.don_hang.Include("chi_tiet_don_hang").Include("khach_hang").Where(a => a.madh == id).FirstOrDefault();

                String user = Session["user"] as String;
               
                if (dh.khachhang == user || Convert.ToBoolean(Session["role"]))
                {
                    return View(dh);
                }
                return RedirectToAction("Error", "Default");
            }
        }
    }
}