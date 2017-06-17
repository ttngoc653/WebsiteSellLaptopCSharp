using SellLaptop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SellLaptop.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }
            return View();
        }

        public ActionResult AddProduct()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(them_san_pham model)
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                using (var ent = new sellLaptopEntities())
                {
                    if (ent.san_pham.Where(a=>a.tensp==model.tensp).First()!=null)
                    {
                        Session["error"] = "LAP TOP "+model.tensp+" ĐÃ TỒN TẠI";
                        return View(model);
                    }

                    san_pham sp = model;
                    ent.san_pham.Add(sp);
                    ent.SaveChanges();


                    int id = sp.masp;

                    anh_sp anhsp = new anh_sp()
                    {
                        masp = id,
                        tenfile = model.anh1.FileName,
                        san_pham = sp
                    };
                    ent.anh_sp.Add(anhsp);
                    ent.SaveChanges();
                                        
                    anhsp.tenfile = model.anh2.FileName;
                    ent.anh_sp.Add(anhsp);
                    ent.SaveChanges();

                    anhsp.tenfile = model.anh3.FileName;
                    ent.anh_sp.Add(anhsp);
                    ent.SaveChanges();

                    anhsp.tenfile = model.anh4.FileName;
                    ent.anh_sp.Add(anhsp);
                    ent.SaveChanges();

                    o_dia_cung odc = new o_dia_cung()
                    {
                        an = false,
                        dungluong = model.ocungdl,
                        loaiodia = model.ocung,
                        masp = id,
                        san_pham = sp
                    };

                    ent.o_dia_cung.Add(odc);
                    ent.SaveChanges();

                    if (model.ocung1!=null||model.ocung1!="")
                    {
                        odc.loaiodia = model.ocung1;
                        odc.dungluong = model.ocungdl1;
                        ent.o_dia_cung.Add(odc);
                        ent.SaveChanges();
                    }

                    Directory.CreateDirectory("~\\Image\\" + id);

                    var fileName = Path.GetFileName(model.icon.FileName);
                    var path = Path.Combine(Server.MapPath("~/Image/" + id), fileName);
                    model.icon.SaveAs(path);

                    fileName = Path.GetFileName(model.anh1.FileName);
                    path = Path.Combine(Server.MapPath("~/Image/" + id), fileName);
                    model.anh1.SaveAs(path);
                    Directory.CreateDirectory("~\\Image\\" + id);

                    fileName = Path.GetFileName(model.anh2.FileName);
                    path = Path.Combine(Server.MapPath("~/Image/" + id), fileName);
                    model.anh2.SaveAs(path);

                    fileName = Path.GetFileName(model.anh3.FileName);
                    path = Path.Combine(Server.MapPath("~/Image/" + id), fileName);
                    model.anh3.SaveAs(path);

                    fileName = Path.GetFileName(model.anh4.FileName);
                    path = Path.Combine(Server.MapPath("~/Image/" + id), fileName);
                    model.anh4.SaveAs(path);
                    
                }

                WebMsgBox.ShowMessage(@"ĐÃ THÊM " + model.tensp + @" THÀNH CÔNG");
            }
            catch (Exception)
            {

                WebMsgBox.ShowMessage(model.tensp + @" THÊM VÀO THẤT BẠI");
            }
            
            return View();
        }

        public ActionResult UpdateCountProduct()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            var ent = new sellLaptopEntities();
            var l = ent.san_pham.ToList();

            return View(l);
        }

        [HttpPost]
        public ActionResult UpdateCountProduct(int id, int number)
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }
            if (number<=0)
            {
                WebMsgBox.ShowMessage(@"SỐ LƯỢNG HÀNG CẬP NHẬT KHÔNG HỢP LỆ!");
                return View();
            }
            using (var ent=new sellLaptopEntities())
            {
                san_pham sp = ent.san_pham.Where(a => a.masp == id).First();
                sp.slcon = number;
                ent.SaveChanges();
                WebMsgBox.ShowMessage("ĐÃ CẬP NHẬT SÔ LƯỢNG SẢN PHẨM THÀNH CÔNG!\nHIỆN TẠI, "+sp.tensp+" CÓ "+sp.slcon+" MÁY");
            }
            return View();
        }

        public ActionResult AddCPU()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddCPU(cpu model)
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }
            try
            {
                using (var ent = new sellLaptopEntities())
                {
                    if (ent.cpus.Where(a=>a.maloai==model.maloai).Count()!=0)
                    {
                        WebMsgBox.ShowMessage(@"ĐÃ CPU CÓ MÃ " + model.maloai + @" TRONG DỮ LIỆU");
                        return View(model);
                    }
                    model.an = 0;
                    ent.cpus.Add(model);
                    ent.SaveChanges();
                    WebMsgBox.ShowMessage(@"THÊM CPU CÓ MÃ " + model.maloai + @" THÀNH CÔNG");
                }
            }
            catch (Exception)
            {
                WebMsgBox.ShowMessage(@"THÊM CPU CÓ MÃ " + model.maloai + @" THẤT BẠI");
            }
            return View(model);
        }

        public ActionResult ManagerAccount()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            using (var ent=new sellLaptopEntities())
            {
                List<khach_hang> l = ent.khach_hang.ToList();
                return View(l);
            }
        }

        public ActionResult DoiQuyen(String id)
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            using (var ent =new sellLaptopEntities())
            {
                khach_hang kh = ent.khach_hang.Where(a => a.tendn == id).First();

                if (kh!=null)
                {
                    kh.quyen = kh.quyen ? false : true;

                    ent.SaveChanges();
                }

                return RedirectToAction("ManagerAccount", "Admin");
            }
        }

        public ActionResult XoaNguoiDung(String id)
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            using (var ent = new sellLaptopEntities())
            {
                if (ent.don_hang.Where(a=>a.khachhang== id).Count()>0)
                {
                    Session["error"] = "KHÔNG THỂ XÓA "+id+ "\nVÌ " + id + " ĐÃ MUA HÀNG";
                    return RedirectToAction("ManagerAccount", "Admin");
                }
                khach_hang kh = ent.khach_hang.Where(a => a.tendn == id).First();

                if (kh != null)
                {
                    ent.khach_hang.Remove(kh);

                    ent.SaveChanges();
                }

                return RedirectToAction("ManagerAccount", "Admin");
            }
        }

        public ActionResult ManagerOrder()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            using (var ent = new sellLaptopEntities())
            {
                List<don_hang> l = ent.don_hang.Include("khach_hang").Include("chi_tiet_don_hang").OrderByDescending(a=>a.ngaygiolap).ToList();
                return View(l);
            }
        }

        public ActionResult AddHangSX()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddHangSX(hang_sx model)
        {            
            try
            {
                using (var ent = new sellLaptopEntities())
                {
                    if (ent.hang_sx.Where(a=>a.tenhangsx==model.tenhangsx).First()!=null)
                    {
                        WebMsgBox.ShowMessage("ĐÃ CÓ HÃNG "+model.tenhangsx+" TRONG DỮ LIỆU!");
                        return View(model);
                    }
                    ent.hang_sx.Add(model);
                    ent.SaveChanges();
                }
                WebMsgBox.ShowMessage("THÊM HÃNG " + model.tenhangsx + "THÀNH CÔNG");
            }
            catch (Exception e)
            {
                WebMsgBox.ShowMessage("LỖI KHI THÊM " + e);
            }
            return View(model);
        }

        public ActionResult ChangeOrder(int id)
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            using (var ent = new sellLaptopEntities())
            {
                don_hang dh = ent.don_hang.Where(a => a.madh == id).First();
                if (dh!=null)
                {
                    dh.dagiao = dh.dagiao ? false : true;
                    ent.SaveChanges();
                }
                return RedirectToAction("ManagerOrder", "Admin");
            }
        }

        public ActionResult AddCartDoHoa()
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }
            return View();
        }

        [HttpPost]
        public ActionResult AddCartDoHoa(cart_do_hoa model)
        {
            if (ktraQuyen() != null)
            {
                return ktraQuyen();
            }

            using (var ent=new sellLaptopEntities())
            {
                if (ent.cart_do_hoa.Where(a=>a.tencartdohoa==model.tencartdohoa).First()!=null)
                {
                    Session["error"] = "ĐÃ CÓ CART ĐỒ HỌA "+model.tencartdohoa+" TRONG DỮ LIỆU";
                    return View(model);
                }
                model.an = false;
                ent.cart_do_hoa.Add(model);
                ent.SaveChanges();
            }
           
            return View(model);
        }

        public ActionResult StatisticasProduct()
        {
            if (ktraQuyen()!=null)
            {
                return ktraQuyen();
            }
            using (var ent=new sellLaptopEntities())
            {
                List<hang_sx> l = ent.hang_sx.Include("san_pham").Include("chi_tiet_don_hang").ToList();
                return View(l);
            }
        }

        public ActionResult ktraQuyen()
        {
            if (Session["role"] == null)
            {
                Session["error"] = "CHỨC NĂNG NÀY ĐÃ BỊ KHÓA.";
                return RedirectToAction("Error", "Default");
            }

            if (Convert.ToBoolean(Session["role"]) != true)
            {
                Session["error"] = "KHÔNG CÓ QUYỀN VÀO TRANG NÀY.";
                return RedirectToAction("Error", "Default");
            }

            return null;
        }

        public ActionResult ListHangSX()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<string> l = ent.hang_sx.Select(a => a.tenhangsx).ToList();
                return PartialView(l);
            }
        }

        public ActionResult ListCPU()
        {
            using (var ent =new sellLaptopEntities())
            {
                List<string> l = ent.cpus.Select(a=>a.maloai).ToList();
                return PartialView(l);
            }
        }
        
        public ActionResult ListRAM()
        {
            return PartialView();
        }

        public ActionResult ListDoHoa()
        {
            using (var ent = new sellLaptopEntities())
            {
                List<string> l = ent.cart_do_hoa.Select(a => a.tencartdohoa).ToList();
                return PartialView(l);
            }
        }
    }
}