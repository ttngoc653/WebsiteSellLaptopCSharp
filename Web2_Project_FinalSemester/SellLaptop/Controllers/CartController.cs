using SellLaptop.Models;
using System;
using System.Collections.Generic;
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
            return View();
        }

        [HttpPost]
        public ActionResult Add(int id, int sl = 1)
        {
            List<Tuple<int, int>> l;
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
                        l = new List<Tuple<int, int>>();
                        l.Add(new Tuple<int, int>(id, sl));
                        WebMsgBox.ShowMessage(@"ĐÃ THÊM THÀNH CÔNG \n HIỆN TẠI CÓ " + sl + @" MÁY " + sp.tenhangsx + " " + sp.tensp + @" TRONG GIỎ!");
                        Session["count_sp"] = sl;
                        Session["cart"] = l;
                    }
                    else
                    {
                        l = Session["cart"] as List<Tuple<int, int>>;
                        Session["count_sp"] = ((int)Session["count_sp"]) + sl;
                        foreach (var item in l)
                        {
                            if (item.Item1==id)
                            {
                                int temp=item.Item2;
                                l.Remove(item);
                                l.Add(new Tuple<int, int>(id, temp + sl));

                                WebMsgBox.ShowMessage(@"ĐÃ THÊM THÀNH CÔNG \n HIỆN TẠI CÓ " + (temp + sl) + @" MÁY " + sp.hang_sx + " " + sp.tensp + @" TRONG GIỎ!");

                                Session["cart"] = l;
                                return View();
                            }
                        }

                        l.Add(new Tuple<int, int>(id, sl));
                        WebMsgBox.ShowMessage(@"ĐÃ THÊM THÀNH CÔNG \n HIỆN TẠI CÓ " + sl + @" MÁY " + sp.hang_sx + " " + sp.tensp + @" TRONG GIỎ!");
                    }
                }
            }
            return View();
        }
    }
}