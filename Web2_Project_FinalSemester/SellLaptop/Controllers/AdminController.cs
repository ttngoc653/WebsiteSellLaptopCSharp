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
            return View();
        }

        public ActionResult AddProduct()
        {
            if (Session["role"] == null)
            {
                WebMsgBox.ShowMessage(@"CHỨC NĂNG NÀY ĐÃ BỊ KHÓA.");
                return RedirectToAction("Index", "Index");
            }

            if ((bool)Session["role"] != true)
            {
                WebMsgBox.ShowMessage(@"KHÔNG CÓ QUYỀN VÀO TRANG NÀY.");
                return RedirectToAction("Index", "Index");
            }

            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(them_san_pham model)
        {
            if (Session["role"]==null)
            {
                WebMsgBox.ShowMessage(@"CHỨC NĂNG NÀY ĐÃ BỊ KHÓA.");
                return RedirectToAction("Index", "Index");
            }

            if ((bool)Session["role"]!=true)
            {
                WebMsgBox.ShowMessage(@"KHÔNG CÓ QUYỀN VÀO TRANG NÀY.");
                return RedirectToAction("Index", "Index");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                using (var ent = new sellLaptopEntities())
                {
                    san_pham sp = model;
                    ent.san_pham.Add(sp);
                    ent.SaveChanges();


                    int id = ent.san_pham.Where(a => a.tensp == model.tensp).Select(a=>a.masp).First();

                    anh_sp anhsp = new anh_sp()
                    {
                        masp = id,
                        tenfile = model.anh1.FileName,
                        san_pham = ent.san_pham.Where(a => a.tensp == model.tensp).First()
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
                        san_pham = ent.san_pham.Where(a => a.tensp == model.tensp).First()
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
            if (Session["role"] == null)
            {
                WebMsgBox.ShowMessage(@"CHỨC NĂNG NÀY ĐÃ BỊ KHÓA.");
                return RedirectToAction("Index", "Index");
            }

            if ((bool)Session["role"] != true)
            {
                WebMsgBox.ShowMessage(@"KHÔNG CÓ QUYỀN VÀO TRANG NÀY.");
                return RedirectToAction("Index", "Index");
            }

            var ent = new sellLaptopEntities();
            var l = ent.san_pham.ToList();

            return View(l);
        }

        [HttpPost]
        public ActionResult UpdateCountProduct(int id, int number)
        {
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

        public ActionResult ManagerAccount()
        {
            using (var ent=new sellLaptopEntities())
            {
                List<khach_hang> l = ent.khach_hang.ToList();
                return View(l);
            }
        }

        public ActionResult DoiQuyen(String id)
        {
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
            using (var ent = new sellLaptopEntities())
            {
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
            using (var ent = new sellLaptopEntities())
            {
                List<don_hang> l = ent.don_hang.ToList();
                return View(l);
            }
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